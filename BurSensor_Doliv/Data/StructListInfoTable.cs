using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurSensor_Doliv.Data
{
    public class StructListInfoTable
    {
        private string _TypeKNBK;
        private double _V1;
        private double _V2;


        public string TypeKNBK { get => _TypeKNBK; set => _TypeKNBK = value; }
        public double V1 { get => _V1; set => _V1 = value; }
        public double V2 { get => _V2; set => _V2 = value; }

    }
}
