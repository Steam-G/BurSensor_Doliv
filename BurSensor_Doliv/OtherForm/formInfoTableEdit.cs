using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurSensor_Doliv.OtherForm
{
    public partial class formInfoTableEdit : Form
    {
        public formInfoTableEdit()
        {
            InitializeComponent();
        }

        public string strKNBK
        {
            get { return tb_Tiporazm.Text; }
            set { tb_Tiporazm.Text = value; }
        }

        public double doublV1
        {
            get { return Convert.ToDouble(tb_V1.Text); }
            set { tb_V1.Text = value.ToString(); }
        }

        public double doublV2
        {
            get { return Convert.ToDouble(tb_V2.Text); }
            set { tb_V2.Text = value.ToString(); }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }

        private void Tb_numb_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char DecSep = Convert.ToChar(NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
            if (e.KeyChar == '.' || e.KeyChar == ',') e.KeyChar = DecSep;
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }
    }
}
