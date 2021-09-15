using BurSensor_Doliv.Data;
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
        async public void SearchIP(ComboBox comboBox, Button button)
        {
            //При поиске IP адресов блокируем выбор и ввод
            comboBox.Enabled = false;
            button.Enabled = false;

            int port = 138;

            List<string> bufIP = new List<string>();
            int iter = 0;

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
                            UdpReceiveResult x = await server.ReceiveAsync();

                            byte[] bytes = x.Buffer;

                            string results = Encoding.UTF8.GetString(bytes);

                            string subString = @"\MAILSLOT\chromatograph";
                            int indexOfSubstring = results.IndexOf(subString); // равно 6

                            if (indexOfSubstring > 0)
                            {
                                string ipServer = x.RemoteEndPoint.Address.ToString();

                                bufIP.Add(ipServer);

                            }
                        }
                    }
                    catch (ObjectDisposedException ex)
                    {
                        server = new UdpClient(port);
                        //MessageBox.Show(ex.Message);
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

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (server != null) server.Close();
                _iplist = new List<string>(bufIP.Distinct());

                comboBox.Items.Clear();
                comboBox.Items.AddRange(IPList.ToArray());
                if (comboBox.Items.Count == 0) comboBox.Items.Add("не найдено");
                comboBox.Items.Add("localhost");
                comboBox.Items.Add("Обновить список");
                comboBox.SelectedIndex = 0;

                comboBox.Enabled = true;
                button.Enabled = true;


            }
        }

        private void tConnectTimeout_Elapsed(object sender, ElapsedEventArgs e)
        {
            server.Close();

            tConnectTimeout.Stop();
            tConnectTimeout.Dispose();
            //throw new NotImplementedException();
        }

        bool status = true;
        private System.Timers.Timer tConnectTimeout;

        async public void tcpClientReadPacket(string ip)
        {
            //SmallProperty[0].Value = ip;
            //_dataStorage.IpAddr = ip;
            const int port = 65004;

            //готовим токен отмены
            _tokenSource = new CancellationTokenSource();
            CancellationToken cancelToken = _tokenSource.Token;
            status = true;

            try
            {
                byte[] buf = new byte[4096];
                int i = 0; // это номер пакета данных, регистрация шлет их несколькими пачками

                while (status)
                {

                    TcpClient client = new TcpClient();

                    await client.ConnectAsync(ip, port);
                    //client.Connect(ip, port);

                    byte[] data = new byte[1514];
                    StringBuilder response = new StringBuilder();
                    NetworkStream stream = client.GetStream();

                    string dataHex = "";
                    string dataString = "";
                    do
                    {
                        int bytes = await stream.ReadAsync(data, 0, data.Length);


                        dataHex = dataHex + ByteArrayToString(data);
                        //int bytes = stream.Read(data, 0, data.Length);

                        response.Append(Encoding.Default.GetString(data, 0, bytes));
                        i++;
                        _StatusLabel.Text = string.Format("IP: {0}, идет опрос (пакет {1})...", ip, i);
                        _StatusLabel.Font = new Font(_StatusLabel.Name, 9, FontStyle.Bold);
                        _StatusLabel.ForeColor = Color.Green;
                        if (i == 5) // интересует определенный пакет, там расположены нужные значения
                        {
                            //FindAndReadUDataStorage(data, response);

                            string paket = response.ToString();
                            //string subString = @"DataStorage";
                            string subString = @"UVEmkOpts";
                            dataString = dataString + response.ToString();
                            int indexOfSubstring = response.ToString().IndexOf(subString); // равно 6
                            int lengthResponce = response.Length;

                            //Def.ZABOI = (decimal)BitConverter.ToDouble(data, indexOfSubstring + 18 - 1514);
                            // IndexOfSubstring - позиция ключевого слова, 
                            // 14 - смещение до первого числового значения (4 байта),
                            // 4 - перепрыгиваем через 4 байта до следующего числового значения
                            // 4 - перепрыгиваем еще через 4 байта до следующего числового значения
                            // прием ведется пакетами по 1514 байт, однако поиск ключевого слова проходит по пачке принятых данных
                            // потому требуется сместиться на неколько пакетов (i-1)*1514 чтобы попасть в нужные отрезок
                            
                            if (indexOfSubstring > -1)
                            {
                                var val = BitConverter.ToSingle(data, indexOfSubstring + 14 + 4 + 4 - 1514 * (i - 1));

                                SmallProperty[0].Value = val.ToString("#.##");
                                _dataStorage.ObemJidkosti = val;

                                // Генерируем событие о изменении листа КНБК
                                ValDolivChanged?.Invoke(this, new EventArgs());
                            }
                            SmallProperty[0].Value = BitConverter.ToSingle(data, indexOfSubstring + 14 + 4 + 4 - 1514 * (i - 1)).ToString("#.##");
                            
                            //SmallProperty[2].Value = BitConverter.ToDouble(data, indexOfSubstring + 18 + 8 - 1514).ToString("#.##");

                            response.Clear();
                            //stream.Dispose();
                            //break;
                        }

                        //if (i >= 100)
                        //{
                        //    response.Clear();
                        //    i = 0;
                        //}
                        // Сохраним в параметрах этот IP
                        Properties.Settings.Default.defaultIP = ip;
                        Properties.Settings.Default.Save();
                        //await Task.Delay(1);
                        if (!stream.DataAvailable)
                        {
                            var availible = stream.DataAvailable;
                        }
                        //response.Clear();
                    }
                    while (stream.DataAvailable); // пока данные есть в потоке

                    //var buferByte = ReadFully(stream);
                    response.Clear();
                    stream.Dispose();
                    // Закрываем потоки
                    stream.Close();
                    client.Close();

                    i = 0;

                    //здесь будет выброшено исключение в случае нажатия на кнопку отмены
                    cancelToken.ThrowIfCancellationRequested();

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
            catch (Exception e)
            {
                _StatusLabel.Text = string.Format("Помехи при приеме от {0} ", ip);
                _StatusLabel.Font = new Font(_StatusLabel.Name, 9, FontStyle.Bold);
                _StatusLabel.ForeColor = Color.DarkRed;

                MessageBox.Show(e.Message);
                //Console.WriteLine("Exception: {0}", e.Message);
            }
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
            tcpClientReadPacket(SmallProperty[0].Value);
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
            _tokenSource.Cancel();
        }

        public static string ByteArrayToString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }
    }
}
