using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurSensor_Doliv
{
    public partial class Form1 : Form
    {
        DataStorage data = new DataStorage();

        public Form1()
        {
            InitializeComponent();
            test();
        }

        private void test()
        {
            data.ValMestorojdenieStr = "Верхнее Пурпейское";
            infoBlock1.dataStorage = data;
            infoBlock1.Refresh();
        }
    }
}
