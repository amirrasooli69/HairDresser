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
            this.comMinTurn = new System.Windows.Forms.ComboBox();
            this.dgShow1 = new System.Windows.Forms.DataGridView();
            this.txtNameTurn = new System.Windows.Forms.TextBox();
            this.dgShow2 = new System.Windows.Forms.DataGridView();
            this.groupTurn = new System.Windows.Forms.GroupBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDateTurn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comColleague = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNumberTurn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEshterakTurn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetDate = new System.Windows.Forms.Button();
            this.pCalander1 = new Papiloo.PCalander();
            ((System.ComponentModel.ISupportInitialize)(this.dgShow1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgShow2)).BeginInit();
            this.groupTurn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTurnPerson
            // 
            this.btnTurnPerson.Location = new System.Drawing.Point(6, 216);
            this.btnTurnPerson.Name = "btnTurnPerson";
            this.btnTurnPerson.Size = new System.Drawing.Size(100, 30);
            this.btnTurnPerson.TabIndex = 2;
            this.btnTurnPerson.Text = "ثبت نوبت";
            this.btnTurnPerson.UseVisualStyleBackColor = true;
            this.btnTurnPerson.Click += new System.EventHandler(this.btnTurnPerson_Click);
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
            this.comHourTurn.Location = new System.Drawing.Point(6, 137);
            this.comHourTurn.Name = "comHourTurn";
            this.comHourTurn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comHourTurn.Size = new System.Drawing.Size(46, 26);
            this.comHourTurn.TabIndex = 3;
            // 
            // comMinTurn
            // 
            this.comMinTurn.FormattingEnabled = true;
            this.comMinTurn.Items.AddRange(new object[] {
            "00",
            "30"});
            this.comMinTurn.Location = new System.Drawing.Point(72, 137);
            this.comMinTurn.Name = "comMinTurn";
            this.comMinTurn.Size = new System.Drawing.Size(46, 26);
            this.comMinTurn.TabIndex = 4;
            // 
            // dgShow1
            // 
            this.dgShow1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShow1.Location = new System.Drawing.Point(412, 8);
            this.dgShow1.MultiSelect = false;
            this.dgShow1.Name = "dgShow1";
            this.dgShow1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgShow1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgShow1.Size = new System.Drawing.Size(394, 575);
            this.dgShow1.TabIndex = 5;
            this.dgShow1.Click += new System.EventHandler(this.dgShow1_Click);
            this.dgShow1.Enter += new System.EventHandler(this.dgShow1_Enter);
            // 
            // txtNameTurn
            // 
            this.txtNameTurn.Location = new System.Drawing.Point(6, 23);
            this.txtNameTurn.Name = "txtNameTurn";
            this.txtNameTurn.Size = new System.Drawing.Size(234, 26);
            this.txtNameTurn.TabIndex = 6;
            this.txtNameTurn.Text = "ali";
            // 
            // dgShow2
            // 
            this.dgShow2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShow2.Location = new System.Drawing.Point(12, 8);
            this.dgShow2.MultiSelect = false;
            this.dgShow2.Name = "dgShow2";
            this.dgShow2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgShow2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgShow2.Size = new System.Drawing.Size(394, 575);
            this.dgShow2.TabIndex = 7;
            this.dgShow2.Click += new System.EventHandler(this.dgShow2_Click);
            this.dgShow2.Enter += new System.EventHandler(this.dgShow2_Enter);
            // 
            // groupTurn
            // 
            this.groupTurn.Controls.Add(this.lbl2);
            this.groupTurn.Controls.Add(this.lbl1);
            this.groupTurn.Controls.Add(this.label6);
            this.groupTurn.Controls.Add(this.txtDateTurn);
            this.groupTurn.Controls.Add(this.label5);
            this.groupTurn.Controls.Add(this.comColleague);
            this.groupTurn.Controls.Add(this.label4);
            this.groupTurn.Controls.Add(this.txtPhoneNumberTurn);
            this.groupTurn.Controls.Add(this.label3);
            this.groupTurn.Controls.Add(this.txtEshterakTurn);
            this.groupTurn.Controls.Add(this.label2);
            this.groupTurn.Controls.Add(this.label1);
            this.groupTurn.Controls.Add(this.txtNameTurn);
            this.groupTurn.Controls.Add(this.comHourTurn);
            this.groupTurn.Controls.Add(this.comMinTurn);
            this.groupTurn.Controls.Add(this.btnTurnPerson);
            this.groupTurn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupTurn.Location = new System.Drawing.Point(814, 5);
            this.groupTurn.Name = "groupTurn";
            this.groupTurn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupTurn.Size = new System.Drawing.Size(323, 256);
            this.groupTurn.TabIndex = 8;
            this.groupTurn.TabStop = false;
            this.groupTurn.Text = "همکار";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl2.Location = new System.Drawing.Point(273, 228);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(44, 18);
            this.lbl2.TabIndex = 18;
            this.lbl2.Text = "همکار";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(154, 228);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(25, 18);
            this.lbl1.TabIndex = 17;
            this.lbl1.Text = "نام";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(238, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "تاریخ و زمان";
            // 
            // txtDateTurn
            // 
            this.txtDateTurn.Location = new System.Drawing.Point(124, 137);
            this.txtDateTurn.Name = "txtDateTurn";
            this.txtDateTurn.Size = new System.Drawing.Size(97, 26);
            this.txtDateTurn.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(272, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "همکار";
            // 
            // comColleague
            // 
            this.comColleague.FormattingEnabled = true;
            this.comColleague.Location = new System.Drawing.Point(6, 177);
            this.comColleague.Name = "comColleague";
            this.comColleague.Size = new System.Drawing.Size(215, 26);
            this.comColleague.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(229, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "شماره تماس";
            // 
            // txtPhoneNumberTurn
            // 
            this.txtPhoneNumberTurn.Location = new System.Drawing.Point(6, 99);
            this.txtPhoneNumberTurn.Name = "txtPhoneNumberTurn";
            this.txtPhoneNumberTurn.Size = new System.Drawing.Size(215, 26);
            this.txtPhoneNumberTurn.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "اشتراک";
            // 
            // txtEshterakTurn
            // 
            this.txtEshterakTurn.Location = new System.Drawing.Point(6, 61);
            this.txtEshterakTurn.Name = "txtEshterakTurn";
            this.txtEshterakTurn.Size = new System.Drawing.Size(215, 26);
            this.txtEshterakTurn.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(55, 137);
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
            this.btnSetDate.Location = new System.Drawing.Point(820, 520);
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
            this.pCalander1.T_Date = "1399/01/21";
            this.pCalander1.TabIndex = 9;
            this.pCalander1.Click += new System.EventHandler(this.pCalander1_Click);
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
        private System.Windows.Forms.ComboBox comMinTurn;
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
        private System.Windows.Forms.ComboBox comColleague;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
    }
}