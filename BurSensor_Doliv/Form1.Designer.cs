namespace BurSensor_Doliv
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            BurSensor_Doliv.DataStorage dataStorage1 = new BurSensor_Doliv.DataStorage();
            BurSensor_Doliv.Data.StructListInfoReis structListInfoReis1 = new BurSensor_Doliv.Data.StructListInfoReis();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BurSensor_Doliv.Data.StructListInfoReis structListInfoReis2 = new BurSensor_Doliv.Data.StructListInfoReis();
            BurSensor_Doliv.LeuzaRegReceiver leuzaRegReceiver1 = new BurSensor_Doliv.LeuzaRegReceiver();
            BurSensor_Doliv.DataStorage dataStorage2 = new BurSensor_Doliv.DataStorage();
            BurSensor_Doliv.Data.StructListInfoReis structListInfoReis3 = new BurSensor_Doliv.Data.StructListInfoReis();
            BurSensor_Doliv.Data.StructListInfoReis structListInfoReis4 = new BurSensor_Doliv.Data.StructListInfoReis();
            BurSensor_Doliv.DataStorage dataStorage3 = new BurSensor_Doliv.DataStorage();
            BurSensor_Doliv.Data.StructListInfoReis structListInfoReis5 = new BurSensor_Doliv.Data.StructListInfoReis();
            BurSensor_Doliv.Data.StructListInfoReis structListInfoReis6 = new BurSensor_Doliv.Data.StructListInfoReis();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.infoReis1 = new BurSensor_Doliv.InfoReis();
            this.connectLeuza1 = new BurSensor_Doliv.Components.ConnectLeuza();
            this.spb_ValDoliv = new Sys_components.SmallPropertyBox();
            this.infoTable1 = new BurSensor_Doliv.InfoTable();
            this.mainTableDoliv1 = new BurSensor_Doliv.Components.MainTableDoliv();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mainTableDoliv1);
            this.splitContainer1.Size = new System.Drawing.Size(1045, 582);
            this.splitContainer1.SplitterDistance = 319;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.infoReis1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.connectLeuza1);
            this.splitContainer2.Panel2.Controls.Add(this.spb_ValDoliv);
            this.splitContainer2.Panel2.Controls.Add(this.infoTable1);
            this.splitContainer2.Size = new System.Drawing.Size(1045, 319);
            this.splitContainer2.SplitterDistance = 574;
            this.splitContainer2.TabIndex = 0;
            // 
            // infoReis1
            // 
            dataStorage1.IpAddr = null;
            dataStorage1.ListDoliva = null;
            structListInfoReis1.ValBrigadaStr = null;
            structListInfoReis1.ValBurilshikStr = null;
            structListInfoReis1.ValKustStr = null;
            structListInfoReis1.ValMasterStr = null;
            structListInfoReis1.ValMestorojdenieStr = null;
            structListInfoReis1.ValOperatorGTIStr = null;
            structListInfoReis1.ValOtvZaUchetKolichestvaBIStr = null;
            structListInfoReis1.ValOtvZaZapolnenieListaDolivaStr = null;
            structListInfoReis1.ValPlotnostBR = 0D;
            structListInfoReis1.ValPlotnostBRStr = null;
            structListInfoReis1.ValPrichinaSPOStr = null;
            structListInfoReis1.ValSkvajinaStr = null;
            structListInfoReis1.ValSupervizerStr = null;
            structListInfoReis1.ValTimeStartSPOStr = null;
            structListInfoReis1.ValZaboi = 0D;
            structListInfoReis1.ValZaboiStr = null;
            dataStorage1.ListInfoReis = structListInfoReis1;
            dataStorage1.ObemJidkosti = 0F;
            dataStorage1.ValBrigadaStr = null;
            dataStorage1.ValBurilshikStr = null;
            dataStorage1.ValDate = new System.DateTime(((long)(0)));
            dataStorage1.ValDateStr = null;
            dataStorage1.ValDoloto = 0D;
            dataStorage1.ValDolotoStr = null;
            dataStorage1.ValeTimeStartSPO = new System.DateTime(((long)(0)));
            dataStorage1.ValKustStr = null;
            dataStorage1.ValMasterStr = null;
            dataStorage1.ValMestorojdenieStr = null;
            dataStorage1.ValObemJidkostiStr = null;
            dataStorage1.ValOperatorGTIStr = null;
            dataStorage1.ValOtvZaUchetKolichestvaBIStr = null;
            dataStorage1.ValOtvZaZapolnenieListaDolivaStr = null;
            dataStorage1.ValPlotnostBR = 0D;
            dataStorage1.ValPlotnostBRStr = null;
            dataStorage1.ValPrichinaSPOStr = null;
            dataStorage1.ValSkvajinaStr = null;
            dataStorage1.ValSupervizerStr = null;
            dataStorage1.ValTimeStartSPOStr = null;
            dataStorage1.ValZaboi = 0D;
            dataStorage1.ValZaboiStr = null;
            this.infoReis1.dataStorage = dataStorage1;
            this.infoReis1.Dock = System.Windows.Forms.DockStyle.Fill;
            structListInfoReis2.ValBrigadaStr = null;
            structListInfoReis2.ValBurilshikStr = null;
            structListInfoReis2.ValKustStr = null;
            structListInfoReis2.ValMasterStr = null;
            structListInfoReis2.ValMestorojdenieStr = null;
            structListInfoReis2.ValOperatorGTIStr = null;
            structListInfoReis2.ValOtvZaUchetKolichestvaBIStr = null;
            structListInfoReis2.ValOtvZaZapolnenieListaDolivaStr = null;
            structListInfoReis2.ValPlotnostBR = 0D;
            structListInfoReis2.ValPlotnostBRStr = null;
            structListInfoReis2.ValPrichinaSPOStr = null;
            structListInfoReis2.ValSkvajinaStr = null;
            structListInfoReis2.ValSupervizerStr = null;
            structListInfoReis2.ValTimeStartSPOStr = null;
            structListInfoReis2.ValZaboi = 0D;
            structListInfoReis2.ValZaboiStr = null;
            this.infoReis1.ListInfoReis = structListInfoReis2;
            this.infoReis1.Location = new System.Drawing.Point(0, 0);
            this.infoReis1.Name = "infoReis1";
            this.infoReis1.Size = new System.Drawing.Size(574, 319);
            this.infoReis1.TabIndex = 0;
            // 
            // connectLeuza1
            // 
            this.connectLeuza1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataStorage2.IpAddr = null;
            dataStorage2.ListDoliva = null;
            structListInfoReis3.ValBrigadaStr = null;
            structListInfoReis3.ValBurilshikStr = null;
            structListInfoReis3.ValKustStr = null;
            structListInfoReis3.ValMasterStr = null;
            structListInfoReis3.ValMestorojdenieStr = null;
            structListInfoReis3.ValOperatorGTIStr = null;
            structListInfoReis3.ValOtvZaUchetKolichestvaBIStr = null;
            structListInfoReis3.ValOtvZaZapolnenieListaDolivaStr = null;
            structListInfoReis3.ValPlotnostBR = 0D;
            structListInfoReis3.ValPlotnostBRStr = null;
            structListInfoReis3.ValPrichinaSPOStr = null;
            structListInfoReis3.ValSkvajinaStr = null;
            structListInfoReis3.ValSupervizerStr = null;
            structListInfoReis3.ValTimeStartSPOStr = null;
            structListInfoReis3.ValZaboi = 0D;
            structListInfoReis3.ValZaboiStr = null;
            dataStorage2.ListInfoReis = structListInfoReis3;
            dataStorage2.ObemJidkosti = 0F;
            dataStorage2.ValBrigadaStr = null;
            dataStorage2.ValBurilshikStr = null;
            dataStorage2.ValDate = new System.DateTime(((long)(0)));
            dataStorage2.ValDateStr = null;
            dataStorage2.ValDoloto = 0D;
            dataStorage2.ValDolotoStr = null;
            dataStorage2.ValeTimeStartSPO = new System.DateTime(((long)(0)));
            dataStorage2.ValKustStr = null;
            dataStorage2.ValMasterStr = null;
            dataStorage2.ValMestorojdenieStr = null;
            dataStorage2.ValObemJidkostiStr = null;
            dataStorage2.ValOperatorGTIStr = null;
            dataStorage2.ValOtvZaUchetKolichestvaBIStr = null;
            dataStorage2.ValOtvZaZapolnenieListaDolivaStr = null;
            dataStorage2.ValPlotnostBR = 0D;
            dataStorage2.ValPlotnostBRStr = null;
            dataStorage2.ValPrichinaSPOStr = null;
            dataStorage2.ValSkvajinaStr = null;
            dataStorage2.ValSupervizerStr = null;
            dataStorage2.ValTimeStartSPOStr = null;
            dataStorage2.ValZaboi = 0D;
            dataStorage2.ValZaboiStr = null;
            leuzaRegReceiver1.DataStorage = dataStorage2;
            leuzaRegReceiver1.IPList = ((System.Collections.Generic.List<string>)(resources.GetObject("leuzaRegReceiver1.IPList")));
            structListInfoReis4.ValBrigadaStr = null;
            structListInfoReis4.ValBurilshikStr = null;
            structListInfoReis4.ValKustStr = null;
            structListInfoReis4.ValMasterStr = null;
            structListInfoReis4.ValMestorojdenieStr = null;
            structListInfoReis4.ValOperatorGTIStr = null;
            structListInfoReis4.ValOtvZaUchetKolichestvaBIStr = null;
            structListInfoReis4.ValOtvZaZapolnenieListaDolivaStr = null;
            structListInfoReis4.ValPlotnostBR = 0D;
            structListInfoReis4.ValPlotnostBRStr = null;
            structListInfoReis4.ValPrichinaSPOStr = null;
            structListInfoReis4.ValSkvajinaStr = null;
            structListInfoReis4.ValSupervizerStr = null;
            structListInfoReis4.ValTimeStartSPOStr = null;
            structListInfoReis4.ValZaboi = 0D;
            structListInfoReis4.ValZaboiStr = null;
            leuzaRegReceiver1.ListInfoReis = structListInfoReis4;
            this.connectLeuza1.LeuzaRegReceiver = leuzaRegReceiver1;
            this.connectLeuza1.Location = new System.Drawing.Point(3, 3);
            this.connectLeuza1.Name = "connectLeuza1";
            this.connectLeuza1.Size = new System.Drawing.Size(464, 80);
            this.connectLeuza1.TabIndex = 2;
            // 
            // spb_ValDoliv
            // 
            this.spb_ValDoliv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spb_ValDoliv.Location = new System.Drawing.Point(0, 260);
            this.spb_ValDoliv.Margin = new System.Windows.Forms.Padding(1);
            this.spb_ValDoliv.Name = "spb_ValDoliv";
            this.spb_ValDoliv.Padding = new System.Windows.Forms.Padding(1);
            this.spb_ValDoliv.PropertyName = null;
            this.spb_ValDoliv.Size = new System.Drawing.Size(467, 58);
            this.spb_ValDoliv.TabIndex = 1;
            this.spb_ValDoliv.Value = null;
            // 
            // infoTable1
            // 
            this.infoTable1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataStorage3.IpAddr = null;
            dataStorage3.ListDoliva = null;
            structListInfoReis5.ValBrigadaStr = null;
            structListInfoReis5.ValBurilshikStr = null;
            structListInfoReis5.ValKustStr = null;
            structListInfoReis5.ValMasterStr = null;
            structListInfoReis5.ValMestorojdenieStr = null;
            structListInfoReis5.ValOperatorGTIStr = null;
            structListInfoReis5.ValOtvZaUchetKolichestvaBIStr = null;
            structListInfoReis5.ValOtvZaZapolnenieListaDolivaStr = null;
            structListInfoReis5.ValPlotnostBR = 0D;
            structListInfoReis5.ValPlotnostBRStr = null;
            structListInfoReis5.ValPrichinaSPOStr = null;
            structListInfoReis5.ValSkvajinaStr = null;
            structListInfoReis5.ValSupervizerStr = null;
            structListInfoReis5.ValTimeStartSPOStr = null;
            structListInfoReis5.ValZaboi = 0D;
            structListInfoReis5.ValZaboiStr = null;
            dataStorage3.ListInfoReis = structListInfoReis5;
            dataStorage3.ObemJidkosti = 0F;
            dataStorage3.ValBrigadaStr = null;
            dataStorage3.ValBurilshikStr = null;
            dataStorage3.ValDate = new System.DateTime(((long)(0)));
            dataStorage3.ValDateStr = null;
            dataStorage3.ValDoloto = 0D;
            dataStorage3.ValDolotoStr = null;
            dataStorage3.ValeTimeStartSPO = new System.DateTime(((long)(0)));
            dataStorage3.ValKustStr = null;
            dataStorage3.ValMasterStr = null;
            dataStorage3.ValMestorojdenieStr = null;
            dataStorage3.ValObemJidkostiStr = null;
            dataStorage3.ValOperatorGTIStr = null;
            dataStorage3.ValOtvZaUchetKolichestvaBIStr = null;
            dataStorage3.ValOtvZaZapolnenieListaDolivaStr = null;
            dataStorage3.ValPlotnostBR = 0D;
            dataStorage3.ValPlotnostBRStr = null;
            dataStorage3.ValPrichinaSPOStr = null;
            dataStorage3.ValSkvajinaStr = null;
            dataStorage3.ValSupervizerStr = null;
            dataStorage3.ValTimeStartSPOStr = null;
            dataStorage3.ValZaboi = 0D;
            dataStorage3.ValZaboiStr = null;
            this.infoTable1.dataStorage = dataStorage3;
            this.infoTable1.Location = new System.Drawing.Point(1, 81);
            this.infoTable1.MinimumSize = new System.Drawing.Size(280, 165);
            this.infoTable1.Name = "infoTable1";
            this.infoTable1.Size = new System.Drawing.Size(466, 175);
            this.infoTable1.TabIndex = 0;
            // 
            // mainTableDoliv1
            // 
            this.mainTableDoliv1.Dock = System.Windows.Forms.DockStyle.Fill;
            structListInfoReis6.ValBrigadaStr = null;
            structListInfoReis6.ValBurilshikStr = null;
            structListInfoReis6.ValKustStr = null;
            structListInfoReis6.ValMasterStr = null;
            structListInfoReis6.ValMestorojdenieStr = null;
            structListInfoReis6.ValOperatorGTIStr = null;
            structListInfoReis6.ValOtvZaUchetKolichestvaBIStr = null;
            structListInfoReis6.ValOtvZaZapolnenieListaDolivaStr = null;
            structListInfoReis6.ValPlotnostBR = 0D;
            structListInfoReis6.ValPlotnostBRStr = null;
            structListInfoReis6.ValPrichinaSPOStr = null;
            structListInfoReis6.ValSkvajinaStr = null;
            structListInfoReis6.ValSupervizerStr = null;
            structListInfoReis6.ValTimeStartSPOStr = null;
            structListInfoReis6.ValZaboi = 0D;
            structListInfoReis6.ValZaboiStr = null;
            this.mainTableDoliv1.ListInfoReis = structListInfoReis6;
            this.mainTableDoliv1.Location = new System.Drawing.Point(0, 0);
            this.mainTableDoliv1.Name = "mainTableDoliv1";
            this.mainTableDoliv1.ObemJidkosti = 0F;
            this.mainTableDoliv1.Size = new System.Drawing.Size(1045, 259);
            this.mainTableDoliv1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 582);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Лист контроля долива / вытеснения (ЗБС)";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private InfoTable infoTable1;
        private InfoReis infoReis1;
        private Components.MainTableDoliv mainTableDoliv1;
        private Sys_components.SmallPropertyBox spb_ValDoliv;
        private Components.ConnectLeuza connectLeuza1;
    }
}

