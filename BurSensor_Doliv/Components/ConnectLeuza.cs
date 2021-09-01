using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurSensor_Doliv.Components
{
    public partial class ConnectLeuza : UserControl
    {
        LeuzaRegReceiver leuzaRegReceiver = new LeuzaRegReceiver();
        List<Control> _ListIndicators = new List<Control>();

        public ConnectLeuza()
        {
            InitializeComponent();
            //ConnectLeuza_Init();
        }

        public void ConnectLeuza_Init()
        {
            //leuzaRegReceiver = new LeuzaRegReceiver();
            leuzaRegReceiver.Init();

            // Привязка элементов на экране к элементам объекта
            for (int i = 0; i < leuzaRegReceiver.SmallProperty.Count; i++)
            {
                _ListIndicators[i].DataBindings.Add("PropertyName", leuzaRegReceiver.SmallProperty[i], "PropertyName", true, DataSourceUpdateMode.OnPropertyChanged);
                _ListIndicators[i].DataBindings.Add("Value", leuzaRegReceiver.SmallProperty[i], "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            }

            cb_Select.Items.Add(Properties.Settings.Default.defaultIP);
            //проверка, есть ли в списке localhost и если нет
            if (cb_Select.Items.IndexOf("localhost") < 0 && cb_Select.Items.IndexOf("127.0.0.1") < 0) cb_Select.Items.Add("localhost");
            cb_Select.Items.Add("Обновить список");
            cb_Select.SelectedIndex = 0;

            
        }

        public void AddControl(Control control)
        {
            _ListIndicators.Add(control);
        }


        private void btn_Connect_Click(object sender, EventArgs e)
        {
            // работа параметрами кнопки, на которую нажали
            var b = sender as Button;
            if (b.Text == "Запустить прием")
            {
                b.Text = "Остановить прием";

                //leuzaRegReceiver.UDPtracking(true);
                //leuzaRegReceiver.tcpClientReadPacket(comboBox1.SelectedItem.ToString());
                leuzaRegReceiver.tcpClientReadPacket(cb_Select.Text);

                //Заблокируем выбор IP адреса, пока опрос не будет остановлен
                cb_Select.Enabled = false;

                // При старте в строке состояния должно быть зеленое сообщение, полужирным шрифтом
                //toolStripStatusLabel1.Text = string.Format("IP: {0}, идет опрос...",leuzaRegReceiver.SmallProperty[0].Value);
                //toolStripStatusLabel1.Font = new Font(toolStripStatusLabel1.Name, 9, FontStyle.Bold);
                //toolStripStatusLabel1.ForeColor = Color.Green;
            }
            else
            {
                b.Text = "Запустить прием";
                leuzaRegReceiver.tcpClientReadPacketStop();

                cb_Select.Enabled = true;
                // По остановке опроса сообщение в строке состояния будет перекрашено в серый цвет и изменится на обычный вид
                //toolStripStatusLabel1.Text = string.Format("IP: {0}, опрос завершен.", leuzaRegReceiver.SmallProperty[0].Value);
                //toolStripStatusLabel1.Font = new Font(toolStripStatusLabel1.Name, 9, FontStyle.Regular);
                //toolStripStatusLabel1.ForeColor = Color.Gray;
            }
        }

        private void cb_Select_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cb_Select.SelectedItem.ToString() == "Обновить список") leuzaRegReceiver.SearchIP((ComboBox)sender, btn_Connect);
        }
    }
}
