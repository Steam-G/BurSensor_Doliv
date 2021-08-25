using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurSensor_Doliv
{
    class DataListDoliva
    {
        private List<StructListDoliva> _ListDoliva;

        public List<StructListDoliva> ListDoliva
        {
            get => _ListDoliva;
            set => _ListDoliva = value;
        }

        public void Add(StructListDoliva dolivLine)
        {
            _ListDoliva.Add(dolivLine);
        }

        public void Remove(int Index)
        {
            _ListDoliva.RemoveAt(Index);
        }

        public void Edit (int Index, StructListDoliva dolivLine)
        {
            _ListDoliva[Index] = dolivLine;
        }
    }
}
