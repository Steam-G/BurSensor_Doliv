﻿using System;
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

            data.ListKNBK = infoTable1.ListKNBK;
            data.ListInfoReis = infoReis1.ListInfoReis;
            data.ListDoliva = mainTableDoliv1.ListDoliva;

            connectLeuza1.AddControl(spb_ValDoliv);
            connectLeuza1.ConnectLeuza_Init();
            test();

            infoTable1.ListKNBKChanged += new EventHandler(ListKNBKChanged);
        }

        private void test()
        {
            infoReis1.ListInfoReis.ValMestorojdenieStr = "Верхнее Пурпейское";
            infoReis1.Refresh();

            infoTable1.dataStorage = data;
        }

        public void ListKNBKChanged(Object sender, EventArgs args)
        {
            InfoTable p = (InfoTable)sender;
            MessageBox.Show("В список добавили: " + p.ListKNBK.Last<Data.StructListInfoTable>().TypeKNBK);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
