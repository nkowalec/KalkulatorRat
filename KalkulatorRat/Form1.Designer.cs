namespace KalkulatorRat
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ActualWibor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.KwotaBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProcentBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SumProcentBox = new System.Windows.Forms.TextBox();
            this.DateFirstBox = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.ObliczBtn = new System.Windows.Forms.Button();
            this.WynikBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IleRatBox = new System.Windows.Forms.TextBox();
            this.numerRatyBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PokazRaty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ActualWibor
            // 
            this.ActualWibor.Location = new System.Drawing.Point(332, 12);
            this.ActualWibor.Name = "ActualWibor";
            this.ActualWibor.ReadOnly = true;
            this.ActualWibor.Size = new System.Drawing.Size(100, 20);
            this.ActualWibor.TabIndex = 0;
            this.ActualWibor.Text = "???";
            this.ActualWibor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ActualWibor.TextChanged += new System.EventHandler(this.ActualWibor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "WIBOR:";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(12, 12);
            this.DateBox.Name = "DateBox";
            this.DateBox.ReadOnly = true;
            this.DateBox.Size = new System.Drawing.Size(100, 20);
            this.DateBox.TabIndex = 2;
            // 
            // KwotaBox
            // 
            this.KwotaBox.Location = new System.Drawing.Point(153, 71);
            this.KwotaBox.Name = "KwotaBox";
            this.KwotaBox.Size = new System.Drawing.Size(173, 20);
            this.KwotaBox.TabIndex = 3;
            this.KwotaBox.Text = "35 000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kwota:";
            // 
            // ProcentBox
            // 
            this.ProcentBox.Location = new System.Drawing.Point(153, 97);
            this.ProcentBox.Name = "ProcentBox";
            this.ProcentBox.Size = new System.Drawing.Size(82, 20);
            this.ProcentBox.TabIndex = 5;
            this.ProcentBox.Text = "4,29";
            this.ProcentBox.TextChanged += new System.EventHandler(this.ProcentBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Procent bazowy:";
            // 
            // SumProcentBox
            // 
            this.SumProcentBox.Location = new System.Drawing.Point(241, 97);
            this.SumProcentBox.Name = "SumProcentBox";
            this.SumProcentBox.ReadOnly = true;
            this.SumProcentBox.Size = new System.Drawing.Size(85, 20);
            this.SumProcentBox.TabIndex = 7;
            // 
            // DateFirstBox
            // 
            this.DateFirstBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateFirstBox.Location = new System.Drawing.Point(153, 146);
            this.DateFirstBox.Name = "DateFirstBox";
            this.DateFirstBox.Size = new System.Drawing.Size(173, 20);
            this.DateFirstBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Data pierwszej raty:";
            // 
            // ObliczBtn
            // 
            this.ObliczBtn.Location = new System.Drawing.Point(153, 181);
            this.ObliczBtn.Name = "ObliczBtn";
            this.ObliczBtn.Size = new System.Drawing.Size(173, 23);
            this.ObliczBtn.TabIndex = 10;
            this.ObliczBtn.Text = "Oblicz wysokość raty";
            this.ObliczBtn.UseVisualStyleBackColor = true;
            this.ObliczBtn.Click += new System.EventHandler(this.ObliczBtn_Click);
            // 
            // WynikBox
            // 
            this.WynikBox.Location = new System.Drawing.Point(112, 229);
            this.WynikBox.Name = "WynikBox";
            this.WynikBox.ReadOnly = true;
            this.WynikBox.Size = new System.Drawing.Size(173, 20);
            this.WynikBox.TabIndex = 11;
            this.WynikBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ilość rat:";
            // 
            // IleRatBox
            // 
            this.IleRatBox.Location = new System.Drawing.Point(153, 121);
            this.IleRatBox.Name = "IleRatBox";
            this.IleRatBox.Size = new System.Drawing.Size(82, 20);
            this.IleRatBox.TabIndex = 12;
            this.IleRatBox.Text = "48";
            // 
            // numerRatyBox
            // 
            this.numerRatyBox.Location = new System.Drawing.Point(291, 229);
            this.numerRatyBox.Name = "numerRatyBox";
            this.numerRatyBox.ReadOnly = true;
            this.numerRatyBox.Size = new System.Drawing.Size(61, 20);
            this.numerRatyBox.TabIndex = 14;
            this.numerRatyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Aktualna rata:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kwota";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Numer";
            // 
            // PokazRaty
            // 
            this.PokazRaty.Enabled = false;
            this.PokazRaty.Location = new System.Drawing.Point(112, 264);
            this.PokazRaty.Name = "PokazRaty";
            this.PokazRaty.Size = new System.Drawing.Size(240, 23);
            this.PokazRaty.TabIndex = 18;
            this.PokazRaty.Text = "Pokaż prognozę rat";
            this.PokazRaty.UseVisualStyleBackColor = true;
            this.PokazRaty.Click += new System.EventHandler(this.PokazRaty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 308);
            this.Controls.Add(this.PokazRaty);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numerRatyBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IleRatBox);
            this.Controls.Add(this.WynikBox);
            this.Controls.Add(this.ObliczBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DateFirstBox);
            this.Controls.Add(this.SumProcentBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProcentBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KwotaBox);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActualWibor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Kalkulator Rat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ActualWibor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.TextBox KwotaBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProcentBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SumProcentBox;
        private System.Windows.Forms.DateTimePicker DateFirstBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ObliczBtn;
        private System.Windows.Forms.TextBox WynikBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IleRatBox;
        private System.Windows.Forms.TextBox numerRatyBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button PokazRaty;
    }
}

