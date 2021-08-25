using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurSensor_Doliv
{
    class StructListDoliva
    {
        private string _TypeKNBK;
        private int _SvechaCapacity;
        private double _MeraBurInstrument;
        private double _ObyemJidkostiDoliv;
        private double _Raschet;
        private double _RaschetSum;
        private double _Fact;
        private double _FactSum;
        private double _SumRaznDoliv;
        private string _Primechanie;

        public string TypeKNBK { get => _TypeKNBK; set => _TypeKNBK = value; }
        public int SvechaCapacity { get => _SvechaCapacity; set => _SvechaCapacity = value; }
        public double MeraBurInstrument { get => _MeraBurInstrument; set => _MeraBurInstrument = value; }
        public double ObyemJidkostiDoliv { get => _ObyemJidkostiDoliv; set => _ObyemJidkostiDoliv = value; }
        public double Raschet { get => _Raschet; set => _Raschet = value; }
        public double RaschetSum { get => _RaschetSum; set => _RaschetSum = value; }
        public double Fact { get => _Fact; set => _Fact = value; }
        public double FactSum { get => _FactSum; set => _FactSum = value; }
        public double SumRaznDoliv { get => _SumRaznDoliv; set => _SumRaznDoliv = value; }
        public string Primechanie { get => _Primechanie; set => _Primechanie = value; }
    }
}
