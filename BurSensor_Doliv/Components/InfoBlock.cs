using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurSensor_Doliv
{
    public partial class InfoBlock : UserControl
    {
        DataStorage data = new DataStorage();

        public InfoBlock()
        {
            InitializeComponent();
            tbData.Columns.Clear();
            tbData.DataSource = data.GetBindingSource();
            
        }

        public DataStorage dataStorage
        {
            get => data;
            set => data = value;
        }

        public void Refresh()
        {
            tbData.DataSource = data.GetBindingSource();
        }
    }
}
