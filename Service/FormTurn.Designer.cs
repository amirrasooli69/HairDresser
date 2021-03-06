﻿namespace Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTurn));
            this.btnTurnPerson = new System.Windows.Forms.Button();
            this.comHourTurn = new System.Windows.Forms.ComboBox();
            this.comMinTurn = new System.Windows.Forms.ComboBox();
            this.txtNameTurn = new System.Windows.Forms.TextBox();
            this.dgShow2 = new System.Windows.Forms.DataGridView();
            this.groupTurn = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnDeleteTurn = new System.Windows.Forms.Button();
            this.btnEditTurn = new System.Windows.Forms.Button();
            this.btnReportColleague = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comState = new System.Windows.Forms.ComboBox();
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
            this.dgShow1 = new System.Windows.Forms.DataGridView();
            this.pCalander1 = new Papiloo.PCalander();
            ((System.ComponentModel.ISupportInitialize)(this.dgShow2)).BeginInit();
            this.groupTurn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShow1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTurnPerson
            // 
            this.btnTurnPerson.Location = new System.Drawing.Point(6, 242);
            this.btnTurnPerson.Name = "btnTurnPerson";
            this.btnTurnPerson.Size = new System.Drawing.Size(83, 30);
            this.btnTurnPerson.TabIndex = 21;
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
            this.comHourTurn.TabIndex = 7;
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
            this.comMinTurn.TabIndex = 9;
            // 
            // txtNameTurn
            // 
            this.txtNameTurn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNameTurn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNameTurn.Location = new System.Drawing.Point(6, 23);
            this.txtNameTurn.Name = "txtNameTurn";
            this.txtNameTurn.Size = new System.Drawing.Size(215, 26);
            this.txtNameTurn.TabIndex = 1;
            this.txtNameTurn.TextChanged += new System.EventHandler(this.txtNameTurn_TextChanged);
            // 
            // dgShow2
            // 
            this.dgShow2.AllowUserToDeleteRows = false;
            this.dgShow2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShow2.Location = new System.Drawing.Point(12, 8);
            this.dgShow2.MultiSelect = false;
            this.dgShow2.Name = "dgShow2";
            this.dgShow2.ReadOnly = true;
            this.dgShow2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgShow2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgShow2.Size = new System.Drawing.Size(394, 628);
            this.dgShow2.TabIndex = 33;
            this.dgShow2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgShow2_CellClick);
            this.dgShow2.Click += new System.EventHandler(this.dgShow2_Click);
            this.dgShow2.Enter += new System.EventHandler(this.dgShow2_Enter);
            // 
            // groupTurn
            // 
            this.groupTurn.Controls.Add(this.lblResult);
            this.groupTurn.Controls.Add(this.progressBar1);
            this.groupTurn.Controls.Add(this.btnDeleteTurn);
            this.groupTurn.Controls.Add(this.btnEditTurn);
            this.groupTurn.Controls.Add(this.btnReportColleague);
            this.groupTurn.Controls.Add(this.btnReport);
            this.groupTurn.Controls.Add(this.label7);
            this.groupTurn.Controls.Add(this.comState);
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
            this.groupTurn.Size = new System.Drawing.Size(323, 306);
            this.groupTurn.TabIndex = 8;
            this.groupTurn.TabStop = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(260, 296);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 18);
            this.lblResult.TabIndex = 18;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(6, 278);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(309, 22);
            this.progressBar1.Step = 2;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 19;
            // 
            // btnDeleteTurn
            // 
            this.btnDeleteTurn.Location = new System.Drawing.Point(217, 242);
            this.btnDeleteTurn.Name = "btnDeleteTurn";
            this.btnDeleteTurn.Size = new System.Drawing.Size(98, 30);
            this.btnDeleteTurn.TabIndex = 25;
            this.btnDeleteTurn.Text = "حذف نوبت";
            this.btnDeleteTurn.UseVisualStyleBackColor = true;
            this.btnDeleteTurn.Click += new System.EventHandler(this.btnDeleteTurn_Click);
            // 
            // btnEditTurn
            // 
            this.btnEditTurn.Location = new System.Drawing.Point(104, 242);
            this.btnEditTurn.Name = "btnEditTurn";
            this.btnEditTurn.Size = new System.Drawing.Size(98, 30);
            this.btnEditTurn.TabIndex = 23;
            this.btnEditTurn.Text = "ویرایش نوبت";
            this.btnEditTurn.UseVisualStyleBackColor = true;
            this.btnEditTurn.Click += new System.EventHandler(this.btnEditTurn_Click);
            // 
            // btnReportColleague
            // 
            this.btnReportColleague.Location = new System.Drawing.Point(6, 172);
            this.btnReportColleague.Name = "btnReportColleague";
            this.btnReportColleague.Size = new System.Drawing.Size(62, 30);
            this.btnReportColleague.TabIndex = 15;
            this.btnReportColleague.Text = "گزارش";
            this.btnReportColleague.UseVisualStyleBackColor = true;
            this.btnReportColleague.Click += new System.EventHandler(this.btnReportColleague_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(6, 206);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(62, 30);
            this.btnReport.TabIndex = 19;
            this.btnReport.Text = "گزارش";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(264, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "وضعیت";
            // 
            // comState
            // 
            this.comState.FormattingEnabled = true;
            this.comState.Items.AddRange(new object[] {
            "فعال",
            "رزرو",
            "کنسل"});
            this.comState.Location = new System.Drawing.Point(72, 207);
            this.comState.Name = "comState";
            this.comState.Size = new System.Drawing.Size(149, 26);
            this.comState.TabIndex = 17;
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
            this.txtDateTurn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDateTurn.Size = new System.Drawing.Size(97, 26);
            this.txtDateTurn.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(272, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "همکار";
            // 
            // comColleague
            // 
            this.comColleague.FormattingEnabled = true;
            this.comColleague.Location = new System.Drawing.Point(72, 172);
            this.comColleague.Name = "comColleague";
            this.comColleague.Size = new System.Drawing.Size(149, 26);
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
            this.txtPhoneNumberTurn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPhoneNumberTurn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPhoneNumberTurn.Location = new System.Drawing.Point(6, 99);
            this.txtPhoneNumberTurn.Name = "txtPhoneNumberTurn";
            this.txtPhoneNumberTurn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhoneNumberTurn.Size = new System.Drawing.Size(215, 26);
            this.txtPhoneNumberTurn.TabIndex = 5;
            this.txtPhoneNumberTurn.TextChanged += new System.EventHandler(this.txtPhoneNumberTurn_TextChanged);
            this.txtPhoneNumberTurn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumberTurn_KeyPress);
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
            this.txtEshterakTurn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEshterakTurn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEshterakTurn.Location = new System.Drawing.Point(6, 61);
            this.txtEshterakTurn.Name = "txtEshterakTurn";
            this.txtEshterakTurn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEshterakTurn.Size = new System.Drawing.Size(215, 26);
            this.txtEshterakTurn.TabIndex = 3;
            this.txtEshterakTurn.TextChanged += new System.EventHandler(this.txtEshterakTurn_TextChanged);
            this.txtEshterakTurn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEshterakTurn_KeyPress);
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
            this.btnSetDate.Location = new System.Drawing.Point(817, 570);
            this.btnSetDate.Name = "btnSetDate";
            this.btnSetDate.Size = new System.Drawing.Size(100, 30);
            this.btnSetDate.TabIndex = 29;
            this.btnSetDate.Text = "تاریخ ";
            this.btnSetDate.UseVisualStyleBackColor = true;
            this.btnSetDate.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgShow1
            // 
            this.dgShow1.AllowUserToDeleteRows = false;
            this.dgShow1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShow1.Location = new System.Drawing.Point(412, 8);
            this.dgShow1.MultiSelect = false;
            this.dgShow1.Name = "dgShow1";
            this.dgShow1.ReadOnly = true;
            this.dgShow1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgShow1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgShow1.Size = new System.Drawing.Size(394, 628);
            this.dgShow1.TabIndex = 31;
            this.dgShow1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgShow1_CellClick);
            this.dgShow1.SelectionChanged += new System.EventHandler(this.dgShow1_SelectionChanged);
            this.dgShow1.Click += new System.EventHandler(this.dgShow1_Click);
            this.dgShow1.Enter += new System.EventHandler(this.dgShow1_Enter);
            // 
            // pCalander1
            // 
            this.pCalander1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pCalander1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pCalander1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pCalander1.Location = new System.Drawing.Point(811, 335);
            this.pCalander1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pCalander1.Name = "pCalander1";
            this.pCalander1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pCalander1.Size = new System.Drawing.Size(330, 228);
            this.pCalander1.T_Date = "1399/01/24";
            this.pCalander1.TabIndex = 27;
            this.pCalander1.Click += new System.EventHandler(this.pCalander1_Click);
            // 
            // FormTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 642);
            this.Controls.Add(this.btnSetDate);
            this.Controls.Add(this.pCalander1);
            this.Controls.Add(this.groupTurn);
            this.Controls.Add(this.dgShow2);
            this.Controls.Add(this.dgShow1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1160, 681);
            this.MinimumSize = new System.Drawing.Size(1160, 681);
            this.Name = "FormTurn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نوبت دهی";
            this.Load += new System.EventHandler(this.FormTurn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgShow2)).EndInit();
            this.groupTurn.ResumeLayout(false);
            this.groupTurn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShow1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTurnPerson;
        private System.Windows.Forms.ComboBox comHourTurn;
        private System.Windows.Forms.ComboBox comMinTurn;
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
        private System.Windows.Forms.DataGridView dgShow1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comState;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnReportColleague;
        private System.Windows.Forms.Button btnDeleteTurn;
        private System.Windows.Forms.Button btnEditTurn;
    }
}