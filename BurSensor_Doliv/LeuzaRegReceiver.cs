using BurSensor_Doliv.Data;
using BurSensor_Doliv.Tools;
using Sys_components;
using Sys_components.Elements;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace BurSensor_Doliv
{
    public class LeuzaRegReceiver
    {
        // Объект с параметрами (далото, забой)
        private DataStorage _dataStorage = new DataStorage();
        // Список объектов, включающих в себя имя параметра и его значение (PropertyName, Value)
        private List<AlphaDataClass> _SmallProperty = new List<AlphaDataClass>();

        private StructListInfoReis _listInfoReis = new StructListInfoReis();

        // объявляем событие для контроля изменения параметра долива
        public event EventHandler ValDolivChanged;

        public DataStorage DataStorage
        {
            get { return _dataStorage; }
            set { _dataStorage = value; }
        }
        public List<AlphaDataClass> SmallProperty
        {
            get { return _SmallProperty; }
            set { _SmallProperty = value; }
        }

        public StructListInfoReis ListInfoReis
        {
            get { return _listInfoReis; }
            set { _listInfoReis = value; }
        }

        public ToolStripStatusLabel StatusLabel
        {
            get { return _StatusLabel; }
            set { _StatusLabel = value; }
        }
        private ToolStripStatusLabel _StatusLabel = new ToolStripStatusLabel();

        // Перечисляем названия параметров, с которыми работаем
        private string[] ParameterNames = {
            "Объем жидк. в доливной емк., м3"//,
            //"Забой, м",
            //"Долото, м"
        };

        public List<string> IPList
        {
            get { return _iplist; }
            set { _iplist = value; }
        }
        private List<string> _iplist = new List<string>();

        //источник токена отмены
        CancellationTokenSource _tokenSource;

        //Экземпляр объекта, работающего с логами
        private Logs l = new Logs();

        public void Init()
        {
            //Заготовка для работы с пользовательским элементом SmallPropertyBox
            //Просто вносим в элементы на форме названия параметров
            for (ushort i = 0; i < ParameterNames.Length; i++)
            {
                SmallProperty.Add(new AlphaDataClass() { PropertyName = /*i.ToString() + ") " +*/ ParameterNames[i] });
            }
        }

        UdpClient server = null;
        //готовим токен отмены
        CancellationTokenSource cancelReceive = new CancellationTokenSource();
        async public void SearchIP(ComboBox comboBox, Button button)
        {
            //При поиске IP адресов блокируем выбор и ввод
            comboBox.Enabled = false;
            button.Enabled = false;

            int port = 138;

            List<string> bufIP = new List<string>();
            int iter = 0;
            if (server != null)
            server.Dispose();
            cancelReceive = new CancellationTokenSource();

            try
            {
                server = new UdpClient(port);
                // Получаем и отдаем сразу. Эхо сервер
                while (iter < 10)
                {
                    try
                    {
                        using (tConnectTimeout = new System.Timers.Timer(1000))
                        {
                            tConnectTimeout.Elapsed += new System.Timers.ElapsedEventHandler(tConnectTimeout_Elapsed);
                            tConnectTimeout.Start();

                            //UdpReceiveResult x = await server.ReceiveAsync();
                            Task<UdpReceiveResult> x = ReceiveAsync(server, cancelReceive.Token);


                            if (x.Result.Buffer == null)
                                throw new RegReceiverException(this, "Нет данных");

                            byte[] bytes = x.Result.Buffer;

                            string results = Encoding.UTF8.GetString(bytes);

                            string subString = @"\MAILSLOT\chromatograph";
                            int indexOfSubstring = results.IndexOf(subString); // равно 6

                            if (indexOfSubstring > 0)
                            {
                                string ipServer = x.Result.RemoteEndPoint.Address.ToString();

                                bufIP.Add(ipServer);

                            }
                        }
                    }
                    //catch (ObjectDisposedException ex)
                    //{
                    //    server.Dispose();
                    //    server = new UdpClient(port);
                    //    MessageBox.Show(ex.Message);
                    //}
                    catch (RegReceiverException ex)
                    {
                        MessageBox.Show("Нет сигнала, возможно вы не подключены к локальной сети, \nлибо в данный момент ни на одном компьютере не работает программа `Регистрация`");
                        iter = 10;
                        
                        return;
                    }
                    tConnectTimeout.Stop();
                    tConnectTimeout.Dispose();
                    //Индикатор прогресса поиска адресов
                    iter++;
                    string progress = new String('▐', iter);
                    await Task.Delay(100);
                    comboBox.Text = progress;

                }
                return;
            }

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            finally
            {
                //if (server != null) server.Close();
                _iplist = new List<string>(bufIP.Distinct());

                comboBox.Items.Clear();
                comboBox.Items.AddRange(IPList.ToArray());
                if (comboBox.Items.Count == 0) comboBox.Items.Add("не найдено");
                comboBox.Items.Add("localhost");
                comboBox.Items.Add("Обновить список");
                comboBox.SelectedIndex = 0;

                comboBox.Enabled = true;
                button.Enabled = true;

                //Dispose(true);
            }
        }

        private void tConnectTimeout_Elapsed(object sender, ElapsedEventArgs e)
        {
            //if (server != null)
            //{
            //    server.Close();
            //    server.Dispose();

            //}
            Dispose(true);
            tConnectTimeout.Stop();
            tConnectTimeout.Dispose();
            //throw new NotImplementedException();
        }

        /// <summary>
        /// Асинхронный запрос на ожидание приёма данных с возможностью досрочного выхода
        /// (для выхода из ожидания вызовите метод Disconnect())
        /// </summary>
        /// <param name="client">Рабочий экземпляр класса UdpClient</param>
        /// <param name="breakToken">Признак досрочного завершения</param>
        /// <returns>Если breakToken произошёл до вызова данного метода или в режиме ожидания
        /// ответа, вернёт пустой UdpReceiveResult; при удачном получении ответа-результат
        /// асинхронной операции чтения</returns>
        public Task<UdpReceiveResult> ReceiveAsync(UdpClient client, CancellationToken breakToken)
            => breakToken.IsCancellationRequested
                ? Task<UdpReceiveResult>.Run(() => new UdpReceiveResult())
                : Task<UdpReceiveResult>.Factory.FromAsync(
                    (callback, state) => client.BeginReceive(callback, state),
                    (ar) =>
                    {
                /// Предотвращение <exception cref="ObjectDisposedException"/>
                if (breakToken.IsCancellationRequested)
                            return new UdpReceiveResult();

                        IPEndPoint remoteEP = null;
                        var buffer = client.EndReceive(ar, ref remoteEP);
                        return new UdpReceiveResult(buffer, remoteEP);
                    },
                    null);

        
        //CancellationToken cancelReceive = _tokenSource.Token;
        protected virtual void Dispose( bool disposing)
        {
            if (disposing)
            {
                this.cancelReceive?.Cancel();
                this.server?.Close();
                this.cancelReceive?.Dispose();
            }
        }

        bool status = true;
        private System.Timers.Timer tConnectTimeout;
        private TcpClient client = new TcpClient();
        float val;

        async public void tcpClientReadPacket(string ip)
        {
            //SmallProperty[0].Value = ip;
            //_dataStorage.IpAddr = ip;
            const int port = 65004;

            // Сохраним в параметрах этот IP
            if (Properties.Settings.Default.defaultIP != ip)
            {
                Properties.Settings.Default.defaultIP = ip;
                Properties.Settings.Default.Save();
            }

            //готовим токен отмены
            _tokenSource = new CancellationTokenSource();
            CancellationToken cancelToken = _tokenSource.Token;

            
            status = true;

            try
            {
                while (status)
                {

                    //client = new TcpClient();
                    //await client.ConnectAsync(ip, port);

                    //byte[] buffer = new byte[client.ReceiveBufferSize];
                    //int bytesCount;
                    //StringBuilder response = new StringBuilder();
                    //NetworkStream stream = client.GetStream();
                    StringBuilder response = await ResponceAsync(ip, port, cancelToken);

                    //do
                    //{
                    //    //_StatusLabel.Text = string.Format("IP: {0}, идет опрос (пакет {1})...", ip, i);
                    //    //_StatusLabel.Font = new Font(_StatusLabel.Name, 9, FontStyle.Bold);
                    //    //_StatusLabel.ForeColor = Color.Green;
                    //    bytesCount = await stream.ReadAsync(buffer, 0, buffer.Length);
                    //    response.Append(Encoding.Default.GetString(buffer, 0, bytesCount));


                    //    //await Task.Delay(1);
                    //    if (!stream.DataAvailable)
                    //    {
                    //        var availible = stream.DataAvailable;
                    //    }
                    //}
                    //while (stream.DataAvailable); // пока данные есть в потоке
                    await Task.Delay(1000);
                    //MessageBox.Show($"{response.Capacity}");
                    byte[] buffer = Encoding.Default.GetBytes(response.ToString());
                    string subString = @"UVEmkOpts";
                    int indexOfSubstring = response.ToString().IndexOf(subString); // IndexOfSubstring - позиция ключевого слова 

                    if (indexOfSubstring > -1)
                    {
                        //val = BitConverter.ToSingle(buffer, indexOfSubstring + 14 + 4 + 4);
                        //string st = response.ToString(indexOfSubstring, 26);
                        //l.LogWrite($"Индекс: {indexOfSubstring}", $"Значение: {val}");
                        //l.LogWrite($"Индекс: {indexOfSubstring}, Байты: {st}", $"Значение: {val}");
                        byte[] valByte = new byte[4];
                        Array.Copy(buffer, indexOfSubstring + 14 + 4 + 4, valByte, 0, 4);
                        SendValueUP(valByte);
                    }

                    //response.Clear();
                    //stream.Dispose();
                    //// Закрываем потоки
                    //stream.Close();
                    //client.Close();

                    ////здесь будет выброшено исключение в случае нажатия на кнопку отмены
                    //cancelToken.ThrowIfCancellationRequested();

                    
                }
            }
            catch (SocketException e)
            {
                _StatusLabel.Text = string.Format("Сигнал с {0} потерян... попытка переподключиться", ip);
                _StatusLabel.Font = new Font(_StatusLabel.Name, 9, FontStyle.Bold);
                _StatusLabel.ForeColor = Color.Red;

                //MessageBox.Show(e.Message);
                await Task.Delay(2000);
                tcpClientReadPacketRestart();
                //Console.WriteLine("SocketException: {0}", e);
            }
            catch (OperationCanceledException)
            {
                _StatusLabel.Text = string.Format("IP: {0}, прием данных завершен.", ip);
                _StatusLabel.Font = new Font(_StatusLabel.Name, 9, FontStyle.Regular);
                _StatusLabel.ForeColor = Color.Gray;
                //MessageBox.Show("Задача отменена.");
                status = false;
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show(e.Message + "\n\nIP адрес: "+ ip + "\nСетевой порт: " + port);
                //Console.WriteLine("Exception: {0}", e.Message);
            }
            catch (ObjectDisposedException ex)
            {
                //server.Dispose();
                //server = new UdpClient(port);
                //MessageBox.Show(ex.Message);
            }
            catch (Exception e)
            {
                _StatusLabel.Text = string.Format("Помехи при приеме от {0} ", ip);
                _StatusLabel.Font = new Font(_StatusLabel.Name, 9, FontStyle.Bold);
                _StatusLabel.ForeColor = Color.DarkRed;

                MessageBox.Show(e.Message + "\nОтрабатываем ошибку");
                //Console.WriteLine("Exception: {0}", e.Message);
            }


        }

        private async Task<StringBuilder> ResponceAsync(string ip, int port, CancellationToken cancelToken)
        {
            client = new TcpClient();
            await client.ConnectAsync(ip, port);

            //byte[] buffer = new byte[client.ReceiveBufferSize];.
            byte[] buffer = new byte[65536];
            int bytesCount;
            StringBuilder response = new StringBuilder();
            NetworkStream stream = client.GetStream();

            do
            {
                //_StatusLabel.Text = string.Format("IP: {0}, идет опрос (пакет {1})...", ip, i);
                //_StatusLabel.Font = new Font(_StatusLabel.Name, 9, FontStyle.Bold);
                //_StatusLabel.ForeColor = Color.Green;
                //MessageBox.Show($"{buffer.Length}");
                bytesCount = await stream.ReadAsync(buffer, 0, buffer.Length);
                response.Append(Encoding.Default.GetString(buffer, 0, bytesCount));


                //await Task.Delay(1);
                if (!stream.DataAvailable)
                {
                    var availible = stream.DataAvailable;
                }
            }
            while (stream.DataAvailable); // пока данные есть в потоке

            //response.Clear();
            stream.Dispose();
            // Закрываем потоки
            stream.Close();
            client.Close();

            //здесь будет выброшено исключение в случае нажатия на кнопку отмены
            cancelToken.ThrowIfCancellationRequested();
            string testresponce = response.ToString(0,response.Capacity);
            return response;
        }

        private static float GetFloatValue(int i, byte[] data, int indexOfSubstring)
        {
            // 14 - смещение до первого числового значения (4 байта),
            // 4 - перепрыгиваем через 4 байта до следующего числового значения
            // 4 - перепрыгиваем еще через 4 байта до следующего числового значения
            // прием ведется пакетами по 1514 байт, однако поиск ключевого слова проходит по пачке принятых данных
            // потому требуется сместиться на неколько пакетов (i-1)*1514 чтобы попасть в нужные отрезок
            return BitConverter.ToSingle(data, indexOfSubstring + 14 + 4 + 4 - 1514 * (i - 1));
        }

        private static float GetNewFloatValue(byte[] data, int indexOfSubstring)
        {
            return BitConverter.ToSingle(data, indexOfSubstring + 14 + 4 + 4);
        }

        private void SendValueUP(float val)
        {
            SmallProperty[0].Value = val.ToString("#.##");
            _dataStorage.ObemJidkosti = val;
            //MessageBox.Show($"{val}");

            // Генерируем событие о изменении листа КНБК
            ValDolivChanged?.Invoke(this, new EventArgs());
        }

        private void SendValueUP(byte[] bytes)
        {
            float value = BitConverter.ToSingle(bytes, 0);
            StringBuilder st = new StringBuilder();
            st.Append(Encoding.Default.GetString(bytes, 0, bytes.Count()));
            SmallProperty[0].Value = value.ToString("#.##");
            _dataStorage.ObemJidkosti = value;
            l.LogWrite($"Байты: {st.ToString()}", $"Значение: {value}");
            //MessageBox.Show($"{val}");

            // Генерируем событие о изменении листа КНБК
            ValDolivChanged?.Invoke(this, new EventArgs());
        }

        public static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        private void tcpClientReadPacketRestart()
        {
            tcpClientReadPacket(Properties.Settings.Default.defaultIP);
        }

        // не используется, но выглядит наглядно
        private void FindAndReadUDataStorage(byte[] data, StringBuilder response)
        {
            string subString = @"UDataStorage";
            int indexOfSubstring = response.ToString().IndexOf(subString); // равно 6

            SmallProperty[1].Value = BitConverter.ToDouble(data, indexOfSubstring + 19 - 1514).ToString("#.##");
            SmallProperty[2].Value = BitConverter.ToDouble(data, indexOfSubstring + 19 + 8 - 1514).ToString("#.##");
        }

        public void tcpClientReadPacketStop()
        {
            //_tokenSource.Cancel();
            this._tokenSource?.Cancel();
            this.client?.Close();
            this._tokenSource?.Dispose();
        }

        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }
    }

    //Реализуем свой класс исключений
    public class RegReceiverException: ApplicationException
    {
        LeuzaRegReceiver leuzaReg;

        public RegReceiverException(LeuzaRegReceiver leuzaReg, string message): base(message)
        {
            this.leuzaReg = leuzaReg;
        }

        public LeuzaRegReceiver LeuzaRegReceiver
        {
            get { return leuzaReg; }
        }
    }
}
