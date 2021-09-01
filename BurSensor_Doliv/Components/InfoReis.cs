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

        private StructListInfoReis _ListInfoReis = new StructListInfoReis();

        public StructListInfoReis ListInfoReis
        {
            get => _ListInfoReis;
            set => _ListInfoReis = value;
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

            bindingSource.DataSource = table;
            return bindingSource;
        }
    }
}
