namespace BurSensor_Doliv.Components
{
    partial class MainTableDoliv
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
            this.splitContainerTableDoliv = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.dgv_Doliv = new System.Windows.Forms.DataGridView();
            this.btn_Save_ExcelDoc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTableDoliv)).BeginInit();
            this.splitContainerTableDoliv.Panel1.SuspendLayout();
            this.splitContainerTableDoliv.Panel2.SuspendLayout();
            this.splitContainerTableDoliv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Doliv)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerTableDoliv
            // 
            this.splitContainerTableDoliv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTableDoliv.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerTableDoliv.IsSplitterFixed = true;
            this.splitContainerTableDoliv.Location = new System.Drawing.Point(0, 0);
            this.splitContainerTableDoliv.Name = "splitContainerTableDoliv";
            this.splitContainerTableDoliv.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerTableDoliv.Panel1
            // 
            this.splitContainerTableDoliv.Panel1.Controls.Add(this.label1);
            this.splitContainerTableDoliv.Panel1.Controls.Add(this.button2);
            this.splitContainerTableDoliv.Panel1.Controls.Add(this.button1);
            this.splitContainerTableDoliv.Panel1.Controls.Add(this.btn_Add);
            // 
            // splitContainerTableDoliv.Panel2
            // 
            this.splitContainerTableDoliv.Panel2.Controls.Add(this.dgv_Doliv);
            this.splitContainerTableDoliv.Size = new System.Drawing.Size(614, 369);
            this.splitContainerTableDoliv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Таблица контроля долива / вытеснения";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Изменить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(3, 24);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(150, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Добавить запись";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_Doliv
            // 
            this.dgv_Doliv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Doliv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Doliv.Location = new System.Drawing.Point(0, 0);
            this.dgv_Doliv.Name = "dgv_Doliv";
            this.dgv_Doliv.ReadOnly = true;
            this.dgv_Doliv.RowHeadersVisible = false;
            this.dgv_Doliv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Doliv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Doliv.Size = new System.Drawing.Size(614, 315);
            this.dgv_Doliv.TabIndex = 0;
            // 
            // btn_Save_ExcelDoc
            // 
            this.btn_Save_ExcelDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save_ExcelDoc.Location = new System.Drawing.Point(469, 3);
            this.btn_Save_ExcelDoc.Name = "btn_Save_ExcelDoc";
            this.btn_Save_ExcelDoc.Size = new System.Drawing.Size(142, 42);
            this.btn_Save_ExcelDoc.TabIndex = 5;
            this.btn_Save_ExcelDoc.Text = "Сохранить отчет";
            this.btn_Save_ExcelDoc.UseVisualStyleBackColor = true;
            this.btn_Save_ExcelDoc.Click += new System.EventHandler(this.btn_Save_ExcelDoc_Click);
            // 
            // MainTableDoliv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Save_ExcelDoc);
            this.Controls.Add(this.splitContainerTableDoliv);
            this.Name = "MainTableDoliv";
            this.Size = new System.Drawing.Size(614, 369);
            this.splitContainerTableDoliv.Panel1.ResumeLayout(false);
            this.splitContainerTableDoliv.Panel1.PerformLayout();
            this.splitContainerTableDoliv.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTableDoliv)).EndInit();
            this.splitContainerTableDoliv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Doliv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerTableDoliv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DataGridView dgv_Doliv;
        private System.Windows.Forms.Button btn_Save_ExcelDoc;
    }
}
