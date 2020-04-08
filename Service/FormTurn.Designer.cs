namespace Service
{
    partial class FormTurn
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
            this.btnTurnPerson = new System.Windows.Forms.Button();
            this.comHourTurn = new System.Windows.Forms.ComboBox();
            this.txtMinTurn = new System.Windows.Forms.ComboBox();
            this.dgShow1 = new System.Windows.Forms.DataGridView();
            this.txtNameTurn = new System.Windows.Forms.TextBox();
            this.dgShow2 = new System.Windows.Forms.DataGridView();
            this.groupTurn = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNumberTurn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEshterakTurn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetDate = new System.Windows.Forms.Button();
            this.pCalander1 = new Papiloo.PCalander();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDateTurn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgShow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgShow2)).BeginInit();
            this.groupTurn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTurnPerson
            // 
            this.btnTurnPerson.Location = new System.Drawing.Point(6, 222);
            this.btnTurnPerson.Name = "btnTurnPerson";
            this.btnTurnPerson.Size = new System.Drawing.Size(100, 30);
            this.btnTurnPerson.TabIndex = 2;
            this.btnTurnPerson.Text = "ثبت نوبت";
            this.btnTurnPerson.UseVisualStyleBackColor = true;
            // 
            // comHourTurn
            // 
            this.comHourTurn.FormattingEnabled = true;
            this.comHourTurn.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comHourTurn.Location = new System.Drawing.Point(6, 144);
            this.comHourTurn.Name = "comHourTurn";
            this.comHourTurn.Size = new System.Drawing.Size(38, 26);
            this.comHourTurn.TabIndex = 3;
            // 
            // txtMinTurn
            // 
            this.txtMinTurn.FormattingEnabled = true;
            this.txtMinTurn.Items.AddRange(new object[] {
            "00",
            "30"});
            this.txtMinTurn.Location = new System.Drawing.Point(66, 144);
            this.txtMinTurn.Name = "txtMinTurn";
            this.txtMinTurn.Size = new System.Drawing.Size(39, 26);
            this.txtMinTurn.TabIndex = 4;
            // 
            // dgShow1
            // 
            this.dgShow1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShow1.Location = new System.Drawing.Point(412, 8);
            this.dgShow1.Name = "dgShow1";
            this.dgShow1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgShow1.Size = new System.Drawing.Size(394, 575);
            this.dgShow1.TabIndex = 5;
            // 
            // txtNameTurn
            // 
            this.txtNameTurn.Location = new System.Drawing.Point(6, 23);
            this.txtNameTurn.Name = "txtNameTurn";
            this.txtNameTurn.Size = new System.Drawing.Size(234, 26);
            this.txtNameTurn.TabIndex = 6;
            // 
            // dgShow2
            // 
            this.dgShow2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShow2.Location = new System.Drawing.Point(12, 8);
            this.dgShow2.Name = "dgShow2";
            this.dgShow2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgShow2.Size = new System.Drawing.Size(394, 575);
            this.dgShow2.TabIndex = 7;
            // 
            // groupTurn
            // 
            this.groupTurn.Controls.Add(this.label6);
            this.groupTurn.Controls.Add(this.txtDateTurn);
            this.groupTurn.Controls.Add(this.label5);
            this.groupTurn.Controls.Add(this.comboBox3);
            this.groupTurn.Controls.Add(this.label4);
            this.groupTurn.Controls.Add(this.txtPhoneNumberTurn);
            this.groupTurn.Controls.Add(this.label3);
            this.groupTurn.Controls.Add(this.txtEshterakTurn);
            this.groupTurn.Controls.Add(this.label2);
            this.groupTurn.Controls.Add(this.label1);
            this.groupTurn.Controls.Add(this.txtNameTurn);
            this.groupTurn.Controls.Add(this.comHourTurn);
            this.groupTurn.Controls.Add(this.txtMinTurn);
            this.groupTurn.Controls.Add(this.btnTurnPerson);
            this.groupTurn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupTurn.Location = new System.Drawing.Point(814, 5);
            this.groupTurn.Name = "groupTurn";
            this.groupTurn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupTurn.Size = new System.Drawing.Size(323, 262);
            this.groupTurn.TabIndex = 8;
            this.groupTurn.TabStop = false;
            this.groupTurn.Text = "همکار";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(229, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "شماره تماس";
            // 
            // txtPhoneNumberTurn
            // 
            this.txtPhoneNumberTurn.Location = new System.Drawing.Point(6, 103);
            this.txtPhoneNumberTurn.Name = "txtPhoneNumberTurn";
            this.txtPhoneNumberTurn.Size = new System.Drawing.Size(210, 26);
            this.txtPhoneNumberTurn.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "اشتراک";
            // 
            // txtEshterakTurn
            // 
            this.txtEshterakTurn.Location = new System.Drawing.Point(6, 65);
            this.txtEshterakTurn.Name = "txtEshterakTurn";
            this.txtEshterakTurn.Size = new System.Drawing.Size(210, 26);
            this.txtEshterakTurn.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(47, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "نام";
            // 
            // btnSetDate
            // 
            this.btnSetDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSetDate.Location = new System.Drawing.Point(814, 520);
            this.btnSetDate.Name = "btnSetDate";
            this.btnSetDate.Size = new System.Drawing.Size(100, 30);
            this.btnSetDate.TabIndex = 10;
            this.btnSetDate.Text = "تاریخ ";
            this.btnSetDate.UseVisualStyleBackColor = true;
            this.btnSetDate.Click += new System.EventHandler(this.button2_Click);
            // 
            // pCalander1
            // 
            this.pCalander1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pCalander1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pCalander1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pCalander1.Location = new System.Drawing.Point(814, 285);
            this.pCalander1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pCalander1.Name = "pCalander1";
            this.pCalander1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pCalander1.Size = new System.Drawing.Size(330, 228);
            this.pCalander1.T_Date = "1399/01/20";
            this.pCalander1.TabIndex = 9;
            this.pCalander1.Click += new System.EventHandler(this.pCalander1_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "00",
            "30"});
            this.comboBox3.Location = new System.Drawing.Point(6, 188);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(210, 26);
            this.comboBox3.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(272, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "همکار";
            // 
            // txtDateTurn
            // 
            this.txtDateTurn.Location = new System.Drawing.Point(113, 144);
            this.txtDateTurn.Name = "txtDateTurn";
            this.txtDateTurn.Size = new System.Drawing.Size(103, 26);
            this.txtDateTurn.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(238, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "تاریخ و زمان";
            // 
            // FormTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 595);
            this.Controls.Add(this.btnSetDate);
            this.Controls.Add(this.pCalander1);
            this.Controls.Add(this.groupTurn);
            this.Controls.Add(this.dgShow2);
            this.Controls.Add(this.dgShow1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTurn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نوبت دهی";
            this.Load += new System.EventHandler(this.FormTurn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgShow1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgShow2)).EndInit();
            this.groupTurn.ResumeLayout(false);
            this.groupTurn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTurnPerson;
        private System.Windows.Forms.ComboBox comHourTurn;
        private System.Windows.Forms.ComboBox txtMinTurn;
        private System.Windows.Forms.DataGridView dgShow1;
        private System.Windows.Forms.TextBox txtNameTurn;
        private System.Windows.Forms.DataGridView dgShow2;
        private System.Windows.Forms.GroupBox groupTurn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNumberTurn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEshterakTurn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Papiloo.PCalander pCalander1;
        private System.Windows.Forms.Button btnSetDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDateTurn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox3;
    }
}