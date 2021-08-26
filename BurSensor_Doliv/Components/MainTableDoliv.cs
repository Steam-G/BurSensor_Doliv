using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurSensor_Doliv.Components
{
    public partial class MainTableDoliv : UserControl
    {
        DataListDoliva ListDoliva = new DataListDoliva();

        public MainTableDoliv()
        {
            InitializeComponent();
            ListDoliva.InitTable(dgv_Doliv);
        }
    }
}
