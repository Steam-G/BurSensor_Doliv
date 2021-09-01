using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurSensor_Doliv.Data
{
    public class StructListInfoReis
    {
        private string _ValMestorojdenieStr;
        private string _ValKustStr;
        private string _ValSkvajinaStr;
        private string _ValBrigadaStr;
        private string _ValBurilshikStr;
        private string _ValOtvZaZapolnenieListaDolivaStr;
        private string _ValOtvZaUchetKolichestvaBIStr;
        private double _ValZaboi;
        private string _ValPrichinaSPOStr;
        private double _ValPlotnostBR;
        private string _ValMasterStr;
        private string _ValSupervizerStr;
        private string _ValOperatorGTIStr;

        private string _ValZaboiStr;
        private string _ValPlotnostBRStr;
        private string _ValTimeStartSPOStr;

        public string ValMestorojdenieStr { get => _ValMestorojdenieStr; set => _ValMestorojdenieStr = value; }
        public string ValKustStr { get => _ValKustStr; set => _ValKustStr = value; }
        public string ValSkvajinaStr { get => _ValSkvajinaStr; set => _ValSkvajinaStr = value; }
        public string ValBrigadaStr { get => _ValBrigadaStr; set => _ValBrigadaStr = value; }
        public string ValBurilshikStr { get => _ValBurilshikStr; set => _ValBurilshikStr = value; }
        public string ValOtvZaZapolnenieListaDolivaStr { get => _ValOtvZaZapolnenieListaDolivaStr; set => _ValOtvZaZapolnenieListaDolivaStr = value; }
        public string ValOtvZaUchetKolichestvaBIStr { get => _ValOtvZaUchetKolichestvaBIStr; set => _ValOtvZaUchetKolichestvaBIStr = value; }
        public double ValZaboi { get => _ValZaboi; set { _ValZaboi = value; ValZaboiStr = value.ToString("#.##"); } }
        public string ValPrichinaSPOStr { get => _ValPrichinaSPOStr; set => _ValPrichinaSPOStr = value; }
        public double ValPlotnostBR { get => _ValPlotnostBR; set { _ValPlotnostBR = value; ValPlotnostBRStr = value.ToString("#.##"); } }
        public string ValMasterStr { get => _ValMasterStr; set => _ValMasterStr = value; }
        public string ValSupervizerStr { get => _ValSupervizerStr; set => _ValSupervizerStr = value; }
        public string ValOperatorGTIStr { get => _ValOperatorGTIStr; set => _ValOperatorGTIStr = value; }

        public string ValZaboiStr { get => _ValZaboiStr; set => _ValZaboiStr = value; }
        public string ValPlotnostBRStr { get => _ValPlotnostBRStr; set => _ValPlotnostBRStr = value; }
        public string ValTimeStartSPOStr { get => _ValTimeStartSPOStr; set => _ValTimeStartSPOStr = value; }


        /*table.Rows[0][1] = _ValMestorojdenieStr;
table.Rows[1][1] = _ValKustStr;
table.Rows[2][1] = _ValSkvajinaStr;
table.Rows[3][1] = _ValBrigadaStr;
table.Rows[4][1] = _ValBurilshikStr;
table.Rows[5][1] = _ValOtvZaZapolnenieListaDolivaStr;
table.Rows[6][1] = _ValOtvZaUchetKolichestvaBIStr;
table.Rows[7][1] = _ValZaboiStr;
table.Rows[8][1] = _ValPrichinaSPOStr;
table.Rows[9][1] = _ValPlotnostBRStr;
table.Rows[10][1] = _ValTimeStartSPOStr;*/
    }
}
