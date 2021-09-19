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

namespace BurSensor_Doliv
{
    public partial class InfoTable : UserControl
    {
        DataStorage data = new DataStorage();

        // объявляем событие для контроля изменения листа КНБК
        public event EventHandler ListKNBKChanged; 

        private List<StructListInfoTable> _ListKNBK = new List<StructListInfoTable>();

        public List<StructListInfoTable> ListKNBK
        {
            get => _ListKNBK;
            set {
                _ListKNBK = value;
                if (ListKNBKChanged != null)
                    ListKNBKChanged(this, new EventArgs());
            }
        }

        public InfoTable()
        {
            InitializeComponent();
            tb_Info.Columns.Clear();
            tb_Info.DataSource = data.GetBindingSourceInfoTable();
        }

        public DataStorage dataStorage
        {
            get => data;
            set => data = value;
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

        public BindingSource GetBindingSourceInfoTable()
        {
            BindingSource bindingSource = new BindingSource();
            DataTable table = new DataTable();

            table.Columns.Add("Типоразмер БИ", typeof(string));
            table.Columns.Add("V п.м.(металла)", typeof(double));
            table.Columns.Add("V п.м.(металл + вн. полость)", typeof(double));

            foreach (var item in _ListKNBK)
            {
                DataRow row = table.NewRow();
                row[0] = item.TypeKNBK;
                row[1] = item.V1;
                row[2] = item.V2;
                table.Rows.Add(row);
            }

            bindingSource.DataSource = table;
            return bindingSource;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            // Создаем форму
            formInfoTableEdit tableEdit = new formInfoTableEdit();

            // отображаем форму
            if (tableEdit.ShowDialog() != DialogResult.OK) return;

            // создаем и заполняем структуру данных КНБК
            Data.StructListInfoTable listInfoTable = new Data.StructListInfoTable();
            listInfoTable.TypeKNBK = tableEdit.strKNBK;
            listInfoTable.V1 = tableEdit.doublV1;
            listInfoTable.V2 = tableEdit.doublV2;

            // добавляем в список КНБК новый объект
            _ListKNBK.Add(listInfoTable);

            Reload();

            // Генерируем событие о изменении листа КНБК
            ListKNBKChanged?.Invoke(this, new EventArgs());
        }

        public void Reload()
        {
            // Обновляем таблицу
            tb_Info.Columns.Clear();
            tb_Info.DataSource = GetBindingSourceInfoTable();
        }

        private void InfoTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                _ListKNBK.RemoveAt(tb_Info.CurrentRow.Index);
                Reload();

                // Генерируем событие о изменении листа КНБК
                ListKNBKChanged?.Invoke(this, new EventArgs());
            }

            if (e.KeyCode == Keys.Enter)
            {
                // Создаем форму
                formInfoTableEdit tableEdit = new formInfoTableEdit();
                tableEdit.strKNBK = _ListKNBK[tb_Info.CurrentRow.Index].TypeKNBK;
                tableEdit.doublV1 = _ListKNBK[tb_Info.CurrentRow.Index].V1;
                tableEdit.doublV2 = _ListKNBK[tb_Info.CurrentRow.Index].V2;

                // отображаем форму
                if (tableEdit.ShowDialog() != DialogResult.OK) return;

                // создаем и заполняем структуру данных КНБК
                Data.StructListInfoTable listInfoTable = new Data.StructListInfoTable();
                listInfoTable.TypeKNBK = tableEdit.strKNBK;
                listInfoTable.V1 = tableEdit.doublV1;
                listInfoTable.V2 = tableEdit.doublV2;

                _ListKNBK[tb_Info.CurrentRow.Index] = listInfoTable;
                Reload();

                // Генерируем событие о изменении листа КНБК
                ListKNBKChanged?.Invoke(this, new EventArgs());
            }
        }
    }
}
