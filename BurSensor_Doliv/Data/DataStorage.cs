using BurSensor_Doliv.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurSensor_Doliv
{
    public class DataStorage : INotifyPropertyChanged
    {
        private double _ValZaboi;
        private double _ValDoloto;
        private double _ValObemJidkosti;
        private double _ValPlotnostBR;
        private DateTime _ValDate;
        private DateTime _ValTimeStartSPO;

        private string _ValZaboiStr; //--
        private string _ValDolotoStr; //--
        private string _ValObemJidkostiStr; //--
        private string _ValMestorojdenieStr;
        private string _ValKustStr;
        private string _ValSkvajinaStr;
        private string _ValBrigadaStr;
        private string _ValBurilshikStr;
        private string _ValOtvZaZapolnenieListaDolivaStr;
        private string _ValOtvZaUchetKolichestvaBIStr;
        private string _ValPrichinaSPOStr;
        private string _ValPlotnostBRStr; //--
        private string _ValDateStr; //--
        private string _ValTimeStartSPOStr; //--
        private string _ValMasterStr;
        private string _ValSupervizerStr;
        private string _ValOperatorGTIStr;

        private string _IpAddr;

        private List<StructListInfoTable> _ListKNBK;

        public List<StructListInfoTable> ListKNBK
        {
            get => _ListKNBK;
            set => _ListKNBK = value;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged(String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public string IpAddr
        {
            get
            {
                return _IpAddr;
            }

            set
            {
                if (_IpAddr != value)
                {
                    _IpAddr = value;
                    NotifyPropertyChanged("IpAddr");

                }
            }
        }

        public double ValZaboi
        {
            get
            {
                return _ValZaboi;
            }

            set
            {
                if (_ValZaboi != value)
                {
                    _ValZaboi = value;
                    NotifyPropertyChanged("ValZaboi");
                    ValZaboiStr = value.ToString("#.##");
                }
            }
        }

        public double ValDoloto
        {
            get
            {
                return _ValDoloto;
            }

            set
            {
                if (_ValDoloto != value)
                {
                    _ValDoloto = value;
                    NotifyPropertyChanged("ValDoloto");
                    ValDolotoStr = value.ToString("#.##");
                }
            }
        }

        public double ObemJidkosti
        {
            get
            {
                return _ValObemJidkosti;
            }

            set
            {
                if (_ValObemJidkosti != value)
                {
                    _ValObemJidkosti = value;
                    NotifyPropertyChanged("ValObemJidkosti");
                    ValObemJidkostiStr = value.ToString("#.##");
                }
            }
        }

        public double ValPlotnostBR
        {
            get
            {
                return _ValPlotnostBR;
            }

            set
            {
                if (_ValPlotnostBR != value)
                {
                    _ValPlotnostBR = value;
                    NotifyPropertyChanged("ValObemJidkosti");
                    ValPlotnostBRStr = value.ToString("#.##");
                }
            }
        }

        public DateTime ValDate
        {
            get
            {
                return _ValDate;
            }

            set
            {
                if (_ValDate != value)
                {
                    _ValDate = value;
                    NotifyPropertyChanged("ValDate");
                    ValDateStr = value.ToString("d", CultureInfo.CreateSpecificCulture("de-DE"));
                }
            }
        }

        public DateTime ValeTimeStartSPO
        {
            get
            {
                return _ValTimeStartSPO;
            }

            set
            {
                if (_ValTimeStartSPO != value)
                {
                    _ValTimeStartSPO = value;
                    NotifyPropertyChanged("ValTimeStartSPO");
                    ValTimeStartSPOStr = value.ToString("t", CultureInfo.CreateSpecificCulture("de-DE"));
                }
            }
        }



        public string ValDolotoStr
        {
            get { return _ValDolotoStr; }
            set
            {
                if (_ValDolotoStr != value)
                {
                    _ValDolotoStr = value;
                    NotifyPropertyChanged("ValDolotoStr");
                }
            }
        }

        public string ValZaboiStr
        {
            get
            {
                return _ValZaboiStr;
            }

            set
            {
                if (_ValZaboiStr != value)
                {
                    _ValZaboiStr = value;
                    NotifyPropertyChanged("ValZaboiStr");
                }
            }
        }

        public string ValObemJidkostiStr
        {
            get
            {
                return _ValObemJidkostiStr;
            }

            set
            {
                if (_ValObemJidkostiStr != value)
                {
                    _ValObemJidkostiStr = value;
                    NotifyPropertyChanged("ValObemJidkostiStr");
                }
            }
        }

        public string ValMestorojdenieStr
        {
            get
            {
                return _ValMestorojdenieStr;
            }

            set
            {
                if (_ValMestorojdenieStr != value)
                {
                    _ValMestorojdenieStr = value;
                    NotifyPropertyChanged("ValMestorojdenieStr");
                }
            }
        }

        public string ValKustStr
        {
            get
            {
                return _ValKustStr;
            }

            set
            {
                if (_ValKustStr != value)
                {
                    _ValKustStr = value;
                    NotifyPropertyChanged("ValKustStr");
                }
            }
        }

        public string ValSkvajinaStr
        {
            get
            {
                return _ValSkvajinaStr;
            }

            set
            {
                if (_ValSkvajinaStr != value)
                {
                    _ValSkvajinaStr = value;
                    NotifyPropertyChanged("ValSkvajinaStr");
                }
            }
        }

        public string ValBrigadaStr
        {
            get
            {
                return _ValBrigadaStr;
            }

            set
            {
                if (_ValBrigadaStr != value)
                {
                    _ValBrigadaStr = value;
                    NotifyPropertyChanged("ValBrigadaStr");
                }
            }
        }

        public string ValBurilshikStr
        {
            get
            {
                return _ValBurilshikStr;
            }

            set
            {
                if (_ValBurilshikStr != value)
                {
                    _ValBurilshikStr = value;
                    NotifyPropertyChanged("ValBurilshikStr");
                }
            }
        }

        public string ValOtvZaZapolnenieListaDolivaStr
        {
            get
            {
                return _ValOtvZaZapolnenieListaDolivaStr;
            }

            set
            {
                if (_ValOtvZaZapolnenieListaDolivaStr != value)
                {
                    _ValOtvZaZapolnenieListaDolivaStr = value;
                    NotifyPropertyChanged("ValOtvZaZapolnenieListaDolivaStr");
                }
            }
        }

        public string ValOtvZaUchetKolichestvaBIStr
        {
            get
            {
                return _ValOtvZaUchetKolichestvaBIStr;
            }

            set
            {
                if (_ValOtvZaUchetKolichestvaBIStr != value)
                {
                    _ValOtvZaUchetKolichestvaBIStr = value;
                    NotifyPropertyChanged("ValOtvZaUchetKolichestvaBIStr");
                }
            }
        }

        public string ValPrichinaSPOStr
        {
            get
            {
                return _ValPrichinaSPOStr;
            }

            set
            {
                if (_ValPrichinaSPOStr != value)
                {
                    _ValPrichinaSPOStr = value;
                    NotifyPropertyChanged("ValPrichinaSPOStr");
                }
            }
        }

        public string ValPlotnostBRStr
        {
            get
            {
                return _ValPlotnostBRStr;
            }

            set
            {
                if (_ValPlotnostBRStr != value)
                {
                    _ValPlotnostBRStr = value;
                    NotifyPropertyChanged("ValPlotnostBRStr");
                }
            }
        }

        public string ValDateStr
        {
            get
            {
                return _ValDateStr;
            }

            set
            {
                if (_ValDateStr != value)
                {
                    _ValDateStr = value;
                    NotifyPropertyChanged("ValDateStr");
                }
            }
        }

        public string ValTimeStartSPOStr
        {
            get
            {
                return _ValTimeStartSPOStr;
            }

            set
            {
                if (_ValTimeStartSPOStr != value)
                {
                    _ValTimeStartSPOStr = value;
                    NotifyPropertyChanged("ValTimeStartSPOStr");
                }
            }
        }

        public string ValMasterStr
        {
            get
            {
                return _ValMasterStr;
            }

            set
            {
                if (_ValMasterStr != value)
                {
                    _ValMasterStr = value;
                    NotifyPropertyChanged("ValMasterStr");
                }
            }
        }

        public string ValSupervizerStr
        {
            get
            {
                return _ValSupervizerStr;
            }

            set
            {
                if (_ValSupervizerStr != value)
                {
                    _ValSupervizerStr = value;
                    NotifyPropertyChanged("ValSupervizerStr");
                }
            }
        }

        public string ValOperatorGTIStr
        {
            get
            {
                return _ValOperatorGTIStr;
            }

            set
            {
                if (_ValOperatorGTIStr != value)
                {
                    _ValOperatorGTIStr = value;
                    NotifyPropertyChanged("ValOperatorGTIStr");
                }
            }
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

            table.Rows[0][1] = _ValMestorojdenieStr;
            table.Rows[1][1] = _ValKustStr;
            table.Rows[2][1] = _ValSkvajinaStr;
            table.Rows[3][1] = _ValBrigadaStr;
            table.Rows[4][1] = _ValBurilshikStr;
            table.Rows[5][1] = _ValOtvZaZapolnenieListaDolivaStr;
            table.Rows[6][1] = _ValOtvZaUchetKolichestvaBIStr;
            table.Rows[7][1] = _ValZaboiStr;
            table.Rows[8][1] = _ValPrichinaSPOStr;
            table.Rows[9][1] = _ValPlotnostBRStr;
            table.Rows[10][1] = _ValTimeStartSPOStr;

            bindingSource.DataSource = table;
            return bindingSource;
        }



        public void InitTable(DataGridView dataGrid)
        {
            DataTable table = new DataTable();
            BindingSource bindingSource = new BindingSource();

            table.Columns.Add("Типоразмер БИ", typeof(string));
            table.Columns.Add("V п.м.(металла)", typeof(double));
            table.Columns.Add("V п.м.(металл + вн. полость)", typeof(double));

            bindingSource.DataSource = table;
            dataGrid.DataSource = bindingSource;
        }

        public void Add(StructListInfoTable structListInfo)
        {
            _ListKNBK.Add(structListInfo);
        }

        public void Remove(int Index)
        {
            _ListKNBK.RemoveAt(Index);
        }

        public void Edit (int Index, StructListInfoTable structListInfo)
        {
            _ListKNBK[Index] = structListInfo;
        }
    }
}