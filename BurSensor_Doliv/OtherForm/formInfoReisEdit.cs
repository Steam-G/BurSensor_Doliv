using BurSensor_Doliv.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurSensor_Doliv.OtherForm
{
    public partial class formInfoReisEdit : Form
    {
        private List<StructListInfoTable> _ListKNBK = new List<StructListInfoTable>();

        public List<StructListInfoTable> ListKNBK
        {
            get => _ListKNBK;
            set => _ListKNBK = value;
        }

        public formInfoReisEdit()
        {
            InitializeComponent();
            //cb_TypeKNBK.Items.AddRange(new string[] { "KNBK1", "KNBK2", "KNBK3", "KNBK4", "KNBK5" });
            
            foreach (var item in _ListKNBK)
            {
                cb_TypeKNBK.Items.Add(item.TypeKNBK);
            }
        }

        public string TypeKNBK              { get => cb_TypeKNBK.Text;                              set => cb_TypeKNBK.Text = value; }
        public int SvechaCapacity           { get => Convert.ToInt32(tb_SvechaCapacity.Text);       set => tb_SvechaCapacity.Text = value.ToString(); }
        public double MeraBurInstrument     { get => Convert.ToDouble(tb_MeraBurInstrument.Text);   set => tb_MeraBurInstrument.Text = value.ToString(); }
        public double ObyemJidkostiDoliv    { get => Convert.ToDouble(tb_ObyemJidkostiDoliv.Text);  set => tb_ObyemJidkostiDoliv.Text = value.ToString(); }
        public double Raschet               { get => Convert.ToDouble(tb_Raschet.Text);             set => tb_Raschet.Text = value.ToString(); }
        public double RaschetSum            { get => Convert.ToDouble(tb_RaschetSum.Text);          set => tb_RaschetSum.Text = value.ToString(); }
        public double Fact                  { get => Convert.ToDouble(tb_Fact.Text);                set => tb_Fact.Text = value.ToString(); }
        public double FactSum               { get => Convert.ToDouble(tb_FactSum.Text);             set => tb_FactSum.Text = value.ToString(); }
        public double SumRaznDoliv          { get => Convert.ToDouble(tb_SumRaznDoliv.Text);        set => tb_SumRaznDoliv.Text = value.ToString(); }
        public string Primechanie           { get => tb_Primechanie.Text;                           set => tb_Primechanie.Text = value; }

        private void Tb_numb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }
    }
}
