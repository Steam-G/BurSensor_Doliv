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

namespace BurSensor_Doliv
{
    public partial class InfoTable : UserControl
    {
        DataStorage data = new DataStorage();

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
            data.AddKNBK(listInfoTable);

            // Обновляем таблицу
            tb_Info.Columns.Clear();
            tb_Info.DataSource = data.GetBindingSourceInfoTable();
        }
    }
}
