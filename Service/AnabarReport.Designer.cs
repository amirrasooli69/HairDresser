namespace Service
{
    partial class AnabarReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelProdoct = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comProdoct = new System.Windows.Forms.ComboBox();
            this.comCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReportProdoct = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.fDate1 = new Papiloo.FDate();
            this.fDate2 = new Papiloo.FDate();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelProdoct.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(835, 360);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(835, 56);
            this.panel2.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(765, 17);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 57;
            this.label4.Text = "موجودی:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(640, 17);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(16, 18);
            this.lblTotalPrice.TabIndex = 56;
            this.lblTotalPrice.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(862, 17);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 55;
            this.label3.Text = "کل کارکرد:";
            // 
            // panelProdoct
            // 
            this.panelProdoct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProdoct.Controls.Add(this.fDate2);
            this.panelProdoct.Controls.Add(this.fDate1);
            this.panelProdoct.Controls.Add(this.label11);
            this.panelProdoct.Controls.Add(this.label12);
            this.panelProdoct.Controls.Add(this.comProdoct);
            this.panelProdoct.Controls.Add(this.comCategory);
            this.panelProdoct.Controls.Add(this.label8);
            this.panelProdoct.Controls.Add(this.btnReportProdoct);
            this.panelProdoct.Controls.Add(this.label10);
            this.panelProdoct.Location = new System.Drawing.Point(12, 12);
            this.panelProdoct.Name = "panelProdoct";
            this.panelProdoct.Size = new System.Drawing.Size(835, 47);
            this.panelProdoct.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(582, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 60;
            this.label11.Text = "تا تاریخ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(778, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 58;
            this.label12.Text = "از تاریخ";
            // 
            // comProdoct
            // 
            this.comProdoct.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comProdoct.FormattingEnabled = true;
            this.comProdoct.Location = new System.Drawing.Point(86, 12);
            this.comProdoct.Name = "comProdoct";
            this.comProdoct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comProdoct.Size = new System.Drawing.Size(117, 24);
            this.comProdoct.TabIndex = 56;
            // 
            // comCategory
            // 
            this.comCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comCategory.FormattingEnabled = true;
            this.comCategory.Location = new System.Drawing.Point(263, 13);
            this.comCategory.Name = "comCategory";
            this.comCategory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comCategory.Size = new System.Drawing.Size(131, 24);
            this.comCategory.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(209, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 54;
            this.label8.Text = "محصول";
            // 
            // btnReportProdoct
            // 
            this.btnReportProdoct.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnReportProdoct.Location = new System.Drawing.Point(9, 8);
            this.btnReportProdoct.Name = "btnReportProdoct";
            this.btnReportProdoct.Size = new System.Drawing.Size(71, 32);
            this.btnReportProdoct.TabIndex = 5;
            this.btnReportProdoct.Text = "گزارش";
            this.btnReportProdoct.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(398, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 53;
            this.label10.Text = "دسته";
            // 
            // fDate1
            // 
            this.fDate1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.fDate1.Location = new System.Drawing.Point(634, 7);
            this.fDate1.Name = "fDate1";
            this.fDate1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fDate1.Size = new System.Drawing.Size(141, 31);
            this.fDate1.TabIndex = 61;
            // 
            // fDate2
            // 
            this.fDate2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.fDate2.Location = new System.Drawing.Point(439, 7);
            this.fDate2.Name = "fDate2";
            this.fDate2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fDate2.Size = new System.Drawing.Size(141, 31);
            this.fDate2.TabIndex = 62;
            // 
            // AnabarReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 497);
            this.Controls.Add(this.panelProdoct);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AnabarReport";
            this.Text = "گزازش انبار";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelProdoct.ResumeLayout(false);
            this.panelProdoct.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPrice;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel panelProdoct;
        private Papiloo.FDate fDate2;
        private Papiloo.FDate fDate1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.ComboBox comProdoct;
        public System.Windows.Forms.ComboBox comCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnReportProdoct;
        private System.Windows.Forms.Label label10;
    }
}