namespace BurSensor_Doliv
{
    partial class InfoBlock
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbData = new System.Windows.Forms.DataGridView();
            this.ColHead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbData)).BeginInit();
            this.SuspendLayout();
            // 
            // tbData
            // 
            this.tbData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColHead,
            this.ColVal});
            this.tbData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbData.Location = new System.Drawing.Point(0, 0);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(513, 224);
            this.tbData.TabIndex = 0;
            // 
            // ColHead
            // 
            this.ColHead.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColHead.FillWeight = 101.5228F;
            this.ColHead.HeaderText = "Заголовок";
            this.ColHead.Name = "ColHead";
            this.ColHead.ReadOnly = true;
            this.ColHead.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColHead.Width = 120;
            // 
            // ColVal
            // 
            this.ColVal.FillWeight = 98.47716F;
            this.ColVal.HeaderText = "Значение";
            this.ColVal.Name = "ColVal";
            // 
            // InfoBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbData);
            this.Name = "InfoBlock";
            this.Size = new System.Drawing.Size(513, 224);
            ((System.ComponentModel.ISupportInitialize)(this.tbData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tbData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHead;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVal;
    }
}
