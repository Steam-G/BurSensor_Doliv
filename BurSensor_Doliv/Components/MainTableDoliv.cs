using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BurSensor_Doliv.OtherForm;
using BurSensor_Doliv.Data;
using BurSensor_Doliv.Excel_doc;

namespace BurSensor_Doliv.Components
{
    public partial class MainTableDoliv : UserControl
    {
        //DataListDoliva ListDoliva = new DataListDoliva();
        // объявляем событие для контроля изменения листа долива
        public event EventHandler ListDolivaChanged;

        private List<StructListDoliva> _ListDoliva = new List<StructListDoliva>();

        public List<StructListDoliva> ListDoliva
        {
            get => _ListDoliva;
            set {
                _ListDoliva = value;
                if (ListDolivaChanged != null)
                    ListDolivaChanged(this, new EventArgs());
            } 
        }

        private List<StructListInfoTable> _ListKNBK = new List<StructListInfoTable>();

        public List<StructListInfoTable> ListKNBK
        {
            get => _ListKNBK;
            set => _ListKNBK = value;
        }

        private StructListInfoReis _ListInfoReis = new StructListInfoReis();

        public StructListInfoReis ListInfoReis
        {
            get => _ListInfoReis;
            set => _ListInfoReis = value;
        }

        private Single _ObemJidkosti;
        public Single ObemJidkosti
        {
            get => _ObemJidkosti;
            set => _ObemJidkosti = value;
        }


        public MainTableDoliv()
        {
            InitializeComponent();
            RefreshTable();
        }

        public void RefreshTable()
        {
            dgv_Doliv.Columns.Clear();
            dgv_Doliv.DataSource = GetBindingSourceInfoTable();

            if (_ListDoliva.Count<1)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                btn_Save_ExcelDoc.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                btn_Save_ExcelDoc.Enabled = true;
            }
        }

        public BindingSource GetBindingSourceInfoTable()
        {
            BindingSource bindingSource = new BindingSource();
            DataTable table = new DataTable();

            table.Columns.Add("Тип элемента КНБК (СБТ, ЛБТ, ТБТ, УБТ)", typeof(string));
            table.Columns.Add("Кол-во свечей / труб", typeof(int));
            table.Columns.Add("Мера бур. инструмента, м", typeof(double));
            table.Columns.Add("Объем жидк. в доливной емк., м3", typeof(double));
            table.Columns.Add("Расчетный объем, м3", typeof(double));
            table.Columns.Add("Расчетный суммарный объем, м3", typeof(double));
            table.Columns.Add("Фактический объем, м3", typeof(double));
            table.Columns.Add("Фактический суммарный объем, м3", typeof(double));
            table.Columns.Add("Суммарная нарастающая разница объема долива/вытеснения, м3", typeof(double));
            table.Columns.Add("Примечание (наличие/отсутствие сифона и т.д.)", typeof(string));

            if (_ListDoliva != null)
            foreach (var item in _ListDoliva)
            {
                DataRow row = table.NewRow();
                row[0] = item.TypeKNBK;
                row[1] = item.SvechaCapacity;
                row[2] = item.MeraBurInstrument;
                row[3] = item.ObyemJidkostiDoliv;
                row[4] = item.Raschet;
                row[5] = item.RaschetSum;
                row[6] = item.Fact;
                row[7] = item.FactSum;
                row[8] = item.SumRaznDoliv;
                row[9] = item.Primechanie;
                table.Rows.Add(row);
            }

            bindingSource.DataSource = table;
            return bindingSource;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            formDolivEdit dolivEdit;
            // Создаем форму
            if (_ListDoliva.Count>0)
            dolivEdit = new formDolivEdit(ListKNBK, _ListDoliva[_ListDoliva.Count-1], true);
            else
            dolivEdit = new formDolivEdit(ListKNBK, new StructListDoliva(), false);

            dolivEdit.ObyemJidkostiDoliv = _ObemJidkosti;
            //dolivEdit.ListKNBK = ListKNBK;
            // Отображаем форму
            if (dolivEdit.ShowDialog() != DialogResult.OK) return;
            // Создаем и заполняем структуру даннаых
            StructListDoliva listDoliva = new StructListDoliva();
            
                listDoliva.TypeKNBK = dolivEdit.TypeKNBK;
                listDoliva.SvechaCapacity = dolivEdit.SvechaCapacity;
                listDoliva.MeraBurInstrument = dolivEdit.MeraBurInstrument;
                listDoliva.ObyemJidkostiDoliv = dolivEdit.ObyemJidkostiDoliv;
                listDoliva.Raschet = dolivEdit.Raschet;
                listDoliva.RaschetSum = dolivEdit.RaschetSum;
                listDoliva.Fact = dolivEdit.Fact;
                listDoliva.FactSum = dolivEdit.FactSum;
                listDoliva.SumRaznDoliv = dolivEdit.SumRaznDoliv;
                listDoliva.Primechanie = dolivEdit.Primechanie;
           
            // Вносим строку в таблицу
            _ListDoliva.Add(listDoliva);

            //Обновляем таблицу
            RefreshTable();

            // Генерируем событие о изменении листа долива
            ListDolivaChanged?.Invoke(this, new EventArgs());
        }

        private void btn_Save_ExcelDoc_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            ExcelDocGen ExcelGen = new ExcelDocGen();
            ExcelGen.Date = date;
            ExcelGen.ListDoliva = _ListDoliva;
            ExcelGen.ListInfoReis = _ListInfoReis;
            ExcelGen.ListKNBK = _ListKNBK;
            ExcelGen.GenerateExeleDoc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formDolivEdit dolivEdit;
            // Создаем форму
            if (dgv_Doliv.CurrentRow.Index > 0)
                dolivEdit = new formDolivEdit(ListKNBK, _ListDoliva[dgv_Doliv.CurrentRow.Index - 1], false);
            else
                dolivEdit = new formDolivEdit(ListKNBK, new StructListDoliva(), false);

            dolivEdit.ObyemJidkostiDoliv = _ObemJidkosti;
            dolivEdit.TypeKNBK = _ListDoliva[dgv_Doliv.CurrentRow.Index].TypeKNBK;
            dolivEdit.SvechaCapacity = _ListDoliva[dgv_Doliv.CurrentRow.Index].SvechaCapacity;
            dolivEdit.MeraBurInstrument = _ListDoliva[dgv_Doliv.CurrentRow.Index].MeraBurInstrument;
            dolivEdit.ObyemJidkostiDoliv = _ListDoliva[dgv_Doliv.CurrentRow.Index].ObyemJidkostiDoliv;
            dolivEdit.Raschet = _ListDoliva[dgv_Doliv.CurrentRow.Index].Raschet;
            dolivEdit.RaschetSum = _ListDoliva[dgv_Doliv.CurrentRow.Index].RaschetSum;
            dolivEdit.Fact = _ListDoliva[dgv_Doliv.CurrentRow.Index].Fact;
            dolivEdit.FactSum = _ListDoliva[dgv_Doliv.CurrentRow.Index].FactSum;
            dolivEdit.SumRaznDoliv = _ListDoliva[dgv_Doliv.CurrentRow.Index].SumRaznDoliv;
            dolivEdit.Primechanie = _ListDoliva[dgv_Doliv.CurrentRow.Index].Primechanie;
            //dolivEdit.ListKNBK = ListKNBK;
            // Отображаем форму
            if (dolivEdit.ShowDialog() != DialogResult.OK) return;
            // Создаем и заполняем структуру даннаых
            StructListDoliva listDoliva = new StructListDoliva();

            listDoliva.TypeKNBK = dolivEdit.TypeKNBK;
            listDoliva.SvechaCapacity = dolivEdit.SvechaCapacity;
            listDoliva.MeraBurInstrument = dolivEdit.MeraBurInstrument;
            listDoliva.ObyemJidkostiDoliv = dolivEdit.ObyemJidkostiDoliv;
            listDoliva.Raschet = dolivEdit.Raschet;
            listDoliva.RaschetSum = dolivEdit.RaschetSum;
            listDoliva.Fact = dolivEdit.Fact;
            listDoliva.FactSum = dolivEdit.FactSum;
            listDoliva.SumRaznDoliv = dolivEdit.SumRaznDoliv;
            listDoliva.Primechanie = dolivEdit.Primechanie;

            // Вносим строку в таблицу
            _ListDoliva[dgv_Doliv.CurrentRow.Index] = listDoliva;
            //Обновляем таблицу
            RefreshTable();

            // Генерируем событие о изменении листа долива
            ListDolivaChanged?.Invoke(this, new EventArgs());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ListDoliva.RemoveAt(dgv_Doliv.CurrentRow.Index);
            //Обновляем таблицу
            RefreshTable();

            // Генерируем событие о изменении листа долива
            ListDolivaChanged?.Invoke(this, new EventArgs());
        }
    }
}
