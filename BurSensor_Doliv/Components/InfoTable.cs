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
            data.InitTable(tb_Info);
        }

        public DataStorage dataStorage
        {
            get => data;
            set => data = value;
        }

        public void Refresh()
        {
            //tb_Info.DataSource = data.GetBindingSource();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            formInfoTableEdit tableEdit = new formInfoTableEdit();
            tableEdit.Show();
        }
    }
}
