using BurSensor_Doliv.Components;
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

            //data.ListKNBK = infoTable1.ListKNBK;
            //data.ListInfoReis = infoReis1.ListInfoReis;
            //data.ListDoliva = mainTableDoliv1.ListDoliva;

            data = DataStorage.LoadFromFile("Doliv.xml");

            infoTable1.ListKNBK = data.ListKNBK;
            infoReis1.ListInfoReis = data.ListInfoReis;
            mainTableDoliv1.ListDoliva = data.ListDoliva;
            mainTableDoliv1.ListKNBK = data.ListKNBK;
            mainTableDoliv1.ListInfoReis = data.ListInfoReis;

            infoTable1.Reload();
            mainTableDoliv1.RefreshTable();

            connectLeuza1.AddControl(spb_ValDoliv);
            connectLeuza1.ConnectLeuza_Init();
            test();

            connectLeuza1.LeuzaRegReceiver.ValDolivChanged += new EventHandler(ValDolivChanged);
            infoTable1.ListKNBKChanged += new EventHandler(ListKNBKChanged);
            infoReis1.ListInfoReisChanged += new EventHandler(ListInfoReisChanged);
            mainTableDoliv1.ListDolivaChanged += new EventHandler(ListDolivaChanged);

        }

        private void test()
        {
            infoReis1.ListInfoReis.ValMestorojdenieStr = "Верхнее Пурпейское";
            infoReis1.Refresh();

            infoTable1.dataStorage = data;
        }

        #region События изменения данных

        public void ValDolivChanged(Object sender, EventArgs args)
        {
            LeuzaRegReceiver p = (LeuzaRegReceiver)sender;
            data.ObemJidkosti = p.DataStorage.ObemJidkosti;
            mainTableDoliv1.ObemJidkosti = p.DataStorage.ObemJidkosti;
            data.Save("Doliv.xml");
        }
        
        public void ListKNBKChanged(Object sender, EventArgs args)
        {
            InfoTable p = (InfoTable)sender;
            data.ListKNBK = p.ListKNBK;
            mainTableDoliv1.ListKNBK = p.ListKNBK;
            //MessageBox.Show("В список добавили: " + p.ListKNBK.Last<Data.StructListInfoTable>().TypeKNBK);
            data.Save("Doliv.xml");
        }

        public void ListInfoReisChanged(Object sender, EventArgs args)
        {
            InfoReis p = (InfoReis)sender;
            data.ListInfoReis = p.ListInfoReis;
            mainTableDoliv1.ListInfoReis = p.ListInfoReis;
            data.Save("Doliv.xml");
        }

        public void ListDolivaChanged(Object sender, EventArgs args)
        {
            MainTableDoliv p = (MainTableDoliv)sender;
            data.ListDoliva = p.ListDoliva;
            data.Save("Doliv.xml");
        }


        #endregion
    }
}
