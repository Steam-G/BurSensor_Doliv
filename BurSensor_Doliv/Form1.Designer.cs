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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.infoBlock1 = new BurSensor_Doliv.InfoBlock();
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
            this.splitContainer1.Size = new System.Drawing.Size(947, 797);
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
            this.splitContainer2.Panel1.Controls.Add(this.infoBlock1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.connectLeuza1);
            this.splitContainer2.Panel2.Controls.Add(this.spb_ValDoliv);
            this.splitContainer2.Panel2.Controls.Add(this.infoTable1);
            this.splitContainer2.Size = new System.Drawing.Size(947, 319);
            this.splitContainer2.SplitterDistance = 662;
            this.splitContainer2.TabIndex = 0;
            // 
            // infoBlock1
            // 
            dataStorage1.IpAddr = null;
            dataStorage1.ObemJidkosti = 0D;
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
            this.infoBlock1.dataStorage = dataStorage1;
            this.infoBlock1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoBlock1.Location = new System.Drawing.Point(0, 0);
            this.infoBlock1.Name = "infoBlock1";
            this.infoBlock1.Size = new System.Drawing.Size(662, 319);
            this.infoBlock1.TabIndex = 0;
            // 
            // connectLeuza1
            // 
            this.connectLeuza1.Location = new System.Drawing.Point(3, 3);
            this.connectLeuza1.Name = "connectLeuza1";
            this.connectLeuza1.Size = new System.Drawing.Size(275, 80);
            this.connectLeuza1.TabIndex = 2;
            // 
            // spb_ValDoliv
            // 
            this.spb_ValDoliv.Location = new System.Drawing.Point(0, 260);
            this.spb_ValDoliv.Margin = new System.Windows.Forms.Padding(1);
            this.spb_ValDoliv.Name = "spb_ValDoliv";
            this.spb_ValDoliv.Padding = new System.Windows.Forms.Padding(1);
            this.spb_ValDoliv.PropertyName = null;
            this.spb_ValDoliv.Size = new System.Drawing.Size(280, 58);
            this.spb_ValDoliv.TabIndex = 1;
            this.spb_ValDoliv.Value = null;
            // 
            // infoTable1
            // 
            this.infoTable1.Location = new System.Drawing.Point(1, 81);
            this.infoTable1.MinimumSize = new System.Drawing.Size(280, 165);
            this.infoTable1.Name = "infoTable1";
            this.infoTable1.Size = new System.Drawing.Size(280, 175);
            this.infoTable1.TabIndex = 0;
            // 
            // mainTableDoliv1
            // 
            this.mainTableDoliv1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableDoliv1.Location = new System.Drawing.Point(0, 0);
            this.mainTableDoliv1.Name = "mainTableDoliv1";
            this.mainTableDoliv1.Size = new System.Drawing.Size(947, 474);
            this.mainTableDoliv1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 797);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private InfoBlock infoBlock1;
        private Components.MainTableDoliv mainTableDoliv1;
        private Sys_components.SmallPropertyBox spb_ValDoliv;
        private Components.ConnectLeuza connectLeuza1;
    }
}

