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
    public partial class formDolivEdit : Form
    {
        private List<StructListInfoTable> _ListKNBK = new List<StructListInfoTable>();
        private StructListDoliva _lastDoliv = new StructListDoliva();

        public List<StructListInfoTable> ListKNBK
        {
            get => _ListKNBK;
            set => _ListKNBK = value;
        }

        public StructListDoliva LastDoliv
        {
            get => _lastDoliv;
            set => _lastDoliv = value;
        }

        bool autoCalc = true;

        public formDolivEdit(List<StructListInfoTable> listKNBK, StructListDoliva lastDoliv, bool autoCalculate)
        {
            InitializeComponent();
            //cb_TypeKNBK.Items.AddRange(new string[] { "KNBK1", "KNBK2", "KNBK3", "KNBK4", "KNBK5" });
            ListKNBK = listKNBK;
            LastDoliv = lastDoliv;
            autoCalc = autoCalculate;
            chbAuto.Checked = !autoCalculate;

            foreach (var item in listKNBK)
            {
                cb_TypeKNBK.Items.Add(item.TypeKNBK);
            }
        }

        public string TypeKNBK              { get => cb_TypeKNBK.Text;                              set => cb_TypeKNBK.Text = value; }
        public int SvechaCapacity           { get => tb_SvechaCapacity.Text == "" ? 0 : Convert.ToInt32(tb_SvechaCapacity.Text); set => tb_SvechaCapacity.Text = value.ToString(); }
        public double MeraBurInstrument     { get => Convert.ToDouble(tb_MeraBurInstrument.Text);   set => tb_MeraBurInstrument.Text = value.ToString(); }
        public double ObyemJidkostiDoliv    { get => Convert.ToDouble(tb_ObyemJidkostiDoliv.Text);  set => tb_ObyemJidkostiDoliv.Text = value.ToString(); }
        public double Raschet               { get => Convert.ToDouble(tb_Raschet.Text);             set => tb_Raschet.Text = value.ToString(); }
        public double RaschetSum            { get => Convert.ToDouble(tb_RaschetSum.Text);          set => tb_RaschetSum.Text = value.ToString(); }
        public double Fact                  { get => Convert.ToDouble(tb_Fact.Text);                set => tb_Fact.Text = value.ToString(); }
        public double FactSum               { get => Convert.ToDouble(tb_FactSum.Text);             set => tb_FactSum.Text = value.ToString(); }
        public double SumRaznDoliv          { get => Convert.ToDouble(tb_SumRaznDoliv.Text);        set => tb_SumRaznDoliv.Text = value.ToString(); }
        public string Primechanie           { get => tb_Primechanie.Text;                           set => tb_Primechanie.Text = value; }

        public int TypeKNBKindex = 0;

        private void Tb_numb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',') e.KeyChar = '.';
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46 && number != 44 && number != 45) // цифры, клавиша BackSpace, точка, запятая и минус
            { 
                e.Handled = true;
            }
        }

        private void cb_TypeKNBK_SelectedIndexChanged(object sender, EventArgs e)
        {
            TypeKNBKindex = cb_TypeKNBK.SelectedIndex;

            try
            {
                if(autoCalc)
                Raschet = (MeraBurInstrument - LastDoliv.MeraBurInstrument) * ListKNBK[TypeKNBKindex].V2;
            }
            catch { }
        }

        private void tb_Raschet_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (autoCalc)
                    RaschetSum = LastDoliv.RaschetSum + Raschet;
            }
            catch { }
        }

        private void tb_RaschetSum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (autoCalc)
                    SumRaznDoliv = RaschetSum + FactSum;
            }
            catch { }
        }

        private void tb_ObyemJidkostiDoliv_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (autoCalc)
                    Fact = ObyemJidkostiDoliv - LastDoliv.ObyemJidkostiDoliv;
            }
            catch { }
        }

        private void tb_MeraBurInstrument_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (autoCalc)
                    Raschet = (MeraBurInstrument - LastDoliv.MeraBurInstrument) * ListKNBK[TypeKNBKindex].V2;
            }
            catch { }
        }

        private void tb_Fact_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (autoCalc)
                    FactSum = LastDoliv.FactSum + Fact;
            }
            catch { }
        }

        private void tb_FactSum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (autoCalc)
                    SumRaznDoliv = FactSum - RaschetSum;
            }
            catch { }
        }

        private void chbAuto_CheckedChanged(object sender, EventArgs e)
        {
            autoCalc = !chbAuto.Checked;
            
        }
    }
}
