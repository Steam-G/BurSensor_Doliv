using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void InitTable(DataGridView dataGrid)
        {
            DataTable table = new DataTable();
            BindingSource bindingSource = new BindingSource();

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

            bindingSource.DataSource = table;
            dataGrid.DataSource = bindingSource;
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
