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
            BurSensor_Doliv.DataStorage dataStorage7 = new BurSensor_Doliv.DataStorage();
            BurSensor_Doliv.Data.StructListInfoReis structListInfoReis10 = new BurSensor_Doliv.Data.StructListInfoReis();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BurSensor_Doliv.Data.StructListInfoReis structListInfoReis11 = new BurSensor_Doliv.Data.StructListInfoReis();
            BurSensor_Doliv.DataStorage dataStorage8 = new BurSensor_Doliv.DataStorage();
            BurSensor_Doliv.Data.StructListInfoReis structListInfoReis12 = new BurSensor_Doliv.Data.StructListInfoReis();
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
            dataStorage7.IpAddr = null;
            dataStorage7.ListDoliva = null;
            structListInfoReis10.ValBrigadaStr = null;
            structListInfoReis10.ValBurilshikStr = null;
            structListInfoReis10.ValKustStr = null;
            structListInfoReis10.ValMasterStr = null;
            structListInfoReis10.ValMestorojdenieStr = null;
            structListInfoReis10.ValOperatorGTIStr = null;
            structListInfoReis10.ValOtvZaUchetKolichestvaBIStr = null;
            structListInfoReis10.ValOtvZaZapolnenieListaDolivaStr = null;
            structListInfoReis10.ValPlotnostBR = 0D;
            structListInfoReis10.ValPlotnostBRStr = null;
            structListInfoReis10.ValPrichinaSPOStr = null;
            structListInfoReis10.ValSkvajinaStr = null;
            structListInfoReis10.ValSupervizerStr = null;
            structListInfoReis10.ValTimeStartSPOStr = null;
            structListInfoReis10.ValZaboi = 0D;
            structListInfoReis10.ValZaboiStr = null;
            dataStorage7.ListInfoReis = structListInfoReis10;
            dataStorage7.ObemJidkosti = 0F;
            dataStorage7.ValBrigadaStr = null;
            dataStorage7.ValBurilshikStr = null;
            dataStorage7.ValDate = new System.DateTime(((long)(0)));
            dataStorage7.ValDateStr = null;
            dataStorage7.ValDoloto = 0D;
            dataStorage7.ValDolotoStr = null;
            dataStorage7.ValeTimeStartSPO = new System.DateTime(((long)(0)));
            dataStorage7.ValKustStr = null;
            dataStorage7.ValMasterStr = null;
            dataStorage7.ValMestorojdenieStr = null;
            dataStorage7.ValObemJidkostiStr = null;
            dataStorage7.ValOperatorGTIStr = null;
            dataStorage7.ValOtvZaUchetKolichestvaBIStr = null;
            dataStorage7.ValOtvZaZapolnenieListaDolivaStr = null;
            dataStorage7.ValPlotnostBR = 0D;
            dataStorage7.ValPlotnostBRStr = null;
            dataStorage7.ValPrichinaSPOStr = null;
            dataStorage7.ValSkvajinaStr = null;
            dataStorage7.ValSupervizerStr = null;
            dataStorage7.ValTimeStartSPOStr = null;
            dataStorage7.ValZaboi = 0D;
            dataStorage7.ValZaboiStr = null;
            this.infoReis1.dataStorage = dataStorage7;
            this.infoReis1.Dock = System.Windows.Forms.DockStyle.Fill;
            structListInfoReis11.ValBrigadaStr = null;
            structListInfoReis11.ValBurilshikStr = null;
            structListInfoReis11.ValKustStr = null;
            structListInfoReis11.ValMasterStr = null;
            structListInfoReis11.ValMestorojdenieStr = null;
            structListInfoReis11.ValOperatorGTIStr = null;
            structListInfoReis11.ValOtvZaUchetKolichestvaBIStr = null;
            structListInfoReis11.ValOtvZaZapolnenieListaDolivaStr = null;
            structListInfoReis11.ValPlotnostBR = 0D;
            structListInfoReis11.ValPlotnostBRStr = null;
            structListInfoReis11.ValPrichinaSPOStr = null;
            structListInfoReis11.ValSkvajinaStr = null;
            structListInfoReis11.ValSupervizerStr = null;
            structListInfoReis11.ValTimeStartSPOStr = null;
            structListInfoReis11.ValZaboi = 0D;
            structListInfoReis11.ValZaboiStr = null;
            this.infoReis1.ListInfoReis = structListInfoReis11;
            this.infoReis1.Location = new System.Drawing.Point(0, 0);
            this.infoReis1.Name = "infoReis1";
            this.infoReis1.Size = new System.Drawing.Size(574, 319);
            this.infoReis1.TabIndex = 0;
            // 
            // connectLeuza1
            // 
            this.connectLeuza1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            dataStorage8.IpAddr = null;
            dataStorage8.ListDoliva = null;
            structListInfoReis12.ValBrigadaStr = null;
            structListInfoReis12.ValBurilshikStr = null;
            structListInfoReis12.ValKustStr = null;
            structListInfoReis12.ValMasterStr = null;
            structListInfoReis12.ValMestorojdenieStr = null;
            structListInfoReis12.ValOperatorGTIStr = null;
            structListInfoReis12.ValOtvZaUchetKolichestvaBIStr = null;
            structListInfoReis12.ValOtvZaZapolnenieListaDolivaStr = null;
            structListInfoReis12.ValPlotnostBR = 0D;
            structListInfoReis12.ValPlotnostBRStr = null;
            structListInfoReis12.ValPrichinaSPOStr = null;
            structListInfoReis12.ValSkvajinaStr = null;
            structListInfoReis12.ValSupervizerStr = null;
            structListInfoReis12.ValTimeStartSPOStr = null;
            structListInfoReis12.ValZaboi = 0D;
            structListInfoReis12.ValZaboiStr = null;
            dataStorage8.ListInfoReis = structListInfoReis12;
            dataStorage8.ObemJidkosti = 0F;
            dataStorage8.ValBrigadaStr = null;
            dataStorage8.ValBurilshikStr = null;
            dataStorage8.ValDate = new System.DateTime(((long)(0)));
            dataStorage8.ValDateStr = null;
            dataStorage8.ValDoloto = 0D;
            dataStorage8.ValDolotoStr = null;
            dataStorage8.ValeTimeStartSPO = new System.DateTime(((long)(0)));
            dataStorage8.ValKustStr = null;
            dataStorage8.ValMasterStr = null;
            dataStorage8.ValMestorojdenieStr = null;
            dataStorage8.ValObemJidkostiStr = null;
            dataStorage8.ValOperatorGTIStr = null;
            dataStorage8.ValOtvZaUchetKolichestvaBIStr = null;
            dataStorage8.ValOtvZaZapolnenieListaDolivaStr = null;
            dataStorage8.ValPlotnostBR = 0D;
            dataStorage8.ValPlotnostBRStr = null;
            dataStorage8.ValPrichinaSPOStr = null;
            dataStorage8.ValSkvajinaStr = null;
            dataStorage8.ValSupervizerStr = null;
            dataStorage8.ValTimeStartSPOStr = null;
            dataStorage8.ValZaboi = 0D;
            dataStorage8.ValZaboiStr = null;
            this.infoTable1.dataStorage = dataStorage8;
            this.infoTable1.Location = new System.Drawing.Point(1, 81);
            this.infoTable1.MinimumSize = new System.Drawing.Size(280, 165);
            this.infoTable1.Name = "infoTable1";
            this.infoTable1.Size = new System.Drawing.Size(466, 175);
            this.infoTable1.TabIndex = 0;
            // 
            // mainTableDoliv1
            // 
            this.mainTableDoliv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableDoliv1.Location = new System.Drawing.Point(0, 0);
            this.mainTableDoliv1.Name = "mainTableDoliv1";
            this.mainTableDoliv1.Size = new System.Drawing.Size(1045, 259);
            this.mainTableDoliv1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 582);
            this.Controls.Add(this.splitContainer1);
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

