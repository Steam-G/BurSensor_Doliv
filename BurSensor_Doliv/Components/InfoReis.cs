using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BurSensor_Doliv.Data;

namespace BurSensor_Doliv
{
    public partial class InfoReis : UserControl
    {
        DataStorage data = new DataStorage();

        // объявляем событие для контроля изменения листа информации по рейсу
        public event EventHandler ListInfoReisChanged;

        private StructListInfoReis _ListInfoReis = new StructListInfoReis();

        public StructListInfoReis ListInfoReis
        {
            get => _ListInfoReis;
            set {
                _ListInfoReis = value;
                if (ListInfoReisChanged != null)
                    ListInfoReisChanged(this, new EventArgs());
            }
        }

        public InfoReis()
        {
            InitializeComponent();
            tbData.Columns.Clear();
            tbData.DataSource = GetBindingSource();
            
        }

        public DataStorage dataStorage
        {
            get => data;
            set => data = value;
        }

        public void Refresh()
        {
            tbData.Columns.Clear();
            tbData.DataSource = GetBindingSource();
        }

        private string[] Zagolovki = new string[]{
            "Месторождение",
            "Куст №",
            "Скважина №",
            "Бригада №",
            "Бурильщики",
            "Ответственные за заполнение листа долива",
            "Ответственные за учет кол-ва поднятого/спущенного БИ",
            "Забой скважины",
            "Причина / Цель СПО",
            "Плотность БР",
            "Время начала СПО"};

        public BindingSource GetBindingSource()
        {
            BindingSource bindingSource = new BindingSource();
            DataTable table = new DataTable();

            table.Columns.Add("Заголовок", typeof(string));
            table.Columns.Add("Значение", typeof(string));

            int i = 0;
            foreach (var item in Zagolovki)
            {
                DataRow row = table.NewRow();
                row[0] = item;
                table.Rows.Add(row);
            }

            table.Rows[0][1] = _ListInfoReis.ValMestorojdenieStr;
            table.Rows[1][1] = _ListInfoReis.ValKustStr;
            table.Rows[2][1] = _ListInfoReis.ValSkvajinaStr;
            table.Rows[3][1] = _ListInfoReis.ValBrigadaStr;
            table.Rows[4][1] = _ListInfoReis.ValBurilshikStr;
            table.Rows[5][1] = _ListInfoReis.ValOtvZaZapolnenieListaDolivaStr;
            table.Rows[6][1] = _ListInfoReis.ValOtvZaUchetKolichestvaBIStr;
            table.Rows[7][1] = _ListInfoReis.ValZaboiStr;
            table.Rows[8][1] = _ListInfoReis.ValPrichinaSPOStr;
            table.Rows[9][1] = _ListInfoReis.ValPlotnostBRStr;
            table.Rows[10][1] = _ListInfoReis.ValTimeStartSPOStr;

            table.Columns[0].ReadOnly = true;

            bindingSource.DataSource = table;
            return bindingSource;
        }

        private void tbData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                switch (e.RowIndex)
                {
                    case 0:
                        _ListInfoReis.ValMestorojdenieStr = tbData[e.ColumnIndex, e.RowIndex].Value.ToString();
                        break;
                    case 1:
                        _ListInfoReis.ValKustStr = tbData[e.ColumnIndex, e.RowIndex].Value.ToString();
                        break;
                    case 2:
                        _ListInfoReis.ValSkvajinaStr = tbData[e.ColumnIndex, e.RowIndex].Value.ToString();
                        break;
                    case 3:
                        _ListInfoReis.ValBrigadaStr = tbData[e.ColumnIndex, e.RowIndex].Value.ToString();
                        break;
                    case 4:
                        _ListInfoReis.ValBurilshikStr = tbData[e.ColumnIndex, e.RowIndex].Value.ToString();
                        break;
                    case 5:
                        _ListInfoReis.ValOtvZaZapolnenieListaDolivaStr = tbData[e.ColumnIndex, e.RowIndex].Value.ToString();
                        break;
                    case 6:
                        _ListInfoReis.ValOtvZaUchetKolichestvaBIStr = tbData[e.ColumnIndex, e.RowIndex].Value.ToString();
                        break;
                    case 7:
                        _ListInfoReis.ValZaboiStr = tbData[e.ColumnIndex, e.RowIndex].Value.ToString();
                        break;
                    case 8:
                        _ListInfoReis.ValPrichinaSPOStr = tbData[e.ColumnIndex, e.RowIndex].Value.ToString();
                        break;
                    case 9:
                        _ListInfoReis.ValPlotnostBRStr = tbData[e.ColumnIndex, e.RowIndex].Value.ToString();
                        break;
                    case 10:
                        _ListInfoReis.ValTimeStartSPOStr = tbData[e.ColumnIndex, e.RowIndex].Value.ToString();
                        break;
                }
                ListInfoReisChanged?.Invoke(this, new EventArgs());
                Refresh();
            }
        }
    }
}
