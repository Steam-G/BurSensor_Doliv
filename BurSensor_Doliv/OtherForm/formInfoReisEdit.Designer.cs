namespace BurSensor_Doliv.OtherForm
{
    partial class formInfoReisEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_SvechaCapacity = new System.Windows.Forms.TextBox();
            this.tb_MeraBurInstrument = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ObyemJidkostiDoliv = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Raschet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_SumRaznDoliv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_Primechanie = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_TypeKNBK = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_RaschetSum = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_FactSum = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_Fact = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(12, 419);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(222, 23);
            this.btnOk.TabIndex = 9;
            this.btnOk.Text = "Сохранить";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(243, 419);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Отмена";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Кол-во свечей / труб";
            // 
            // tb_SvechaCapacity
            // 
            this.tb_SvechaCapacity.Location = new System.Drawing.Point(160, 64);
            this.tb_SvechaCapacity.Name = "tb_SvechaCapacity";
            this.tb_SvechaCapacity.Size = new System.Drawing.Size(151, 20);
            this.tb_SvechaCapacity.TabIndex = 11;
            this.tb_SvechaCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_numb_KeyPress);
            // 
            // tb_MeraBurInstrument
            // 
            this.tb_MeraBurInstrument.Location = new System.Drawing.Point(160, 90);
            this.tb_MeraBurInstrument.Name = "tb_MeraBurInstrument";
            this.tb_MeraBurInstrument.Size = new System.Drawing.Size(151, 20);
            this.tb_MeraBurInstrument.TabIndex = 13;
            this.tb_MeraBurInstrument.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_numb_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Мера бур. инструмента, м";
            // 
            // tb_ObyemJidkostiDoliv
            // 
            this.tb_ObyemJidkostiDoliv.Location = new System.Drawing.Point(160, 122);
            this.tb_ObyemJidkostiDoliv.Name = "tb_ObyemJidkostiDoliv";
            this.tb_ObyemJidkostiDoliv.Size = new System.Drawing.Size(151, 20);
            this.tb_ObyemJidkostiDoliv.TabIndex = 15;
            this.tb_ObyemJidkostiDoliv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_numb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Объем жидк. \r\nв доливной емк., м3";
            // 
            // tb_Raschet
            // 
            this.tb_Raschet.Location = new System.Drawing.Point(148, 19);
            this.tb_Raschet.Name = "tb_Raschet";
            this.tb_Raschet.Size = new System.Drawing.Size(151, 20);
            this.tb_Raschet.TabIndex = 17;
            this.tb_Raschet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_numb_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Объем, м3";
            // 
            // tb_SumRaznDoliv
            // 
            this.tb_SumRaznDoliv.Location = new System.Drawing.Point(160, 326);
            this.tb_SumRaznDoliv.Name = "tb_SumRaznDoliv";
            this.tb_SumRaznDoliv.Size = new System.Drawing.Size(151, 20);
            this.tb_SumRaznDoliv.TabIndex = 25;
            this.tb_SumRaznDoliv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_numb_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 39);
            this.label9.TabIndex = 24;
            this.label9.Text = "Суммарная нарастающая \r\nразница объема \r\nдолива / вытеснения, м3";
            // 
            // tb_Primechanie
            // 
            this.tb_Primechanie.Location = new System.Drawing.Point(160, 366);
            this.tb_Primechanie.Name = "tb_Primechanie";
            this.tb_Primechanie.Size = new System.Drawing.Size(151, 20);
            this.tb_Primechanie.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 26);
            this.label10.TabIndex = 26;
            this.label10.Text = "Примечание (наличие / \r\nотсутствие сифона и т.д.)";
            // 
            // cb_TypeKNBK
            // 
            this.cb_TypeKNBK.FormattingEnabled = true;
            this.cb_TypeKNBK.Location = new System.Drawing.Point(6, 19);
            this.cb_TypeKNBK.Name = "cb_TypeKNBK";
            this.cb_TypeKNBK.Size = new System.Drawing.Size(293, 21);
            this.cb_TypeKNBK.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.tb_RaschetSum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_Raschet);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 75);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Расчетный объём";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Сумм. объём, м3";
            // 
            // tb_RaschetSum
            // 
            this.tb_RaschetSum.Location = new System.Drawing.Point(148, 45);
            this.tb_RaschetSum.Name = "tb_RaschetSum";
            this.tb_RaschetSum.Size = new System.Drawing.Size(151, 20);
            this.tb_RaschetSum.TabIndex = 19;
            this.tb_RaschetSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_numb_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_FactSum);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tb_Fact);
            this.groupBox2.Location = new System.Drawing.Point(12, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 75);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Фактический объём";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Сумм. объём, м3";
            // 
            // tb_FactSum
            // 
            this.tb_FactSum.Location = new System.Drawing.Point(148, 45);
            this.tb_FactSum.Name = "tb_FactSum";
            this.tb_FactSum.Size = new System.Drawing.Size(151, 20);
            this.tb_FactSum.TabIndex = 19;
            this.tb_FactSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_numb_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Объем, м3";
            // 
            // tb_Fact
            // 
            this.tb_Fact.Location = new System.Drawing.Point(148, 19);
            this.tb_Fact.Name = "tb_Fact";
            this.tb_Fact.Size = new System.Drawing.Size(151, 20);
            this.tb_Fact.TabIndex = 17;
            this.tb_Fact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_numb_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_TypeKNBK);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 46);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Тип элемента КНБК (СБТ, ЛБТ, ТБТ, УБТ)";
            // 
            // formInfoReisEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 454);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_Primechanie);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb_SumRaznDoliv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_ObyemJidkostiDoliv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_MeraBurInstrument);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_SvechaCapacity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formInfoReisEdit";
            this.Text = "Добавить / изменить данные";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_SvechaCapacity;
        private System.Windows.Forms.TextBox tb_MeraBurInstrument;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ObyemJidkostiDoliv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Raschet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_SumRaznDoliv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_Primechanie;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_TypeKNBK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_RaschetSum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_FactSum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_Fact;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}