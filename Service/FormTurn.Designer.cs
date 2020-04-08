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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dgShow1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgShow2 = new System.Windows.Forms.DataGridView();
            this.groupTurn = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.btnTurnPerson.Location = new System.Drawing.Point(6, 176);
            this.btnTurnPerson.Name = "btnTurnPerson";
            this.btnTurnPerson.Size = new System.Drawing.Size(100, 30);
            this.btnTurnPerson.TabIndex = 2;
            this.btnTurnPerson.Text = "ثبت نوبت";
            this.btnTurnPerson.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
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
            this.comboBox1.Location = new System.Drawing.Point(6, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 26);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "00",
            "30"});
            this.comboBox2.Location = new System.Drawing.Point(84, 144);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(57, 26);
            this.comboBox2.TabIndex = 4;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 26);
            this.textBox1.TabIndex = 6;
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
            this.groupTurn.Controls.Add(this.label4);
            this.groupTurn.Controls.Add(this.textBox3);
            this.groupTurn.Controls.Add(this.label3);
            this.groupTurn.Controls.Add(this.textBox2);
            this.groupTurn.Controls.Add(this.label2);
            this.groupTurn.Controls.Add(this.label1);
            this.groupTurn.Controls.Add(this.textBox1);
            this.groupTurn.Controls.Add(this.comboBox1);
            this.groupTurn.Controls.Add(this.comboBox2);
            this.groupTurn.Controls.Add(this.btnTurnPerson);
            this.groupTurn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupTurn.Location = new System.Drawing.Point(814, 5);
            this.groupTurn.Name = "groupTurn";
            this.groupTurn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupTurn.Size = new System.Drawing.Size(283, 216);
            this.groupTurn.TabIndex = 8;
            this.groupTurn.TabStop = false;
            this.groupTurn.Text = "نوبت";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(183, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "شماره تماس";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 103);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 26);
            this.textBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "اشتراک";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 26);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(62, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "نام";
            // 
            // btnSetDate
            // 
            this.btnSetDate.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSetDate.Location = new System.Drawing.Point(818, 463);
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
            this.pCalander1.Location = new System.Drawing.Point(814, 228);
            this.pCalander1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pCalander1.Name = "pCalander1";
            this.pCalander1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pCalander1.Size = new System.Drawing.Size(330, 228);
            this.pCalander1.T_Date = "1399/01/20";
            this.pCalander1.TabIndex = 9;
            this.pCalander1.Click += new System.EventHandler(this.pCalander1_Click);
            // 
            // FormTurn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 595);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dgShow1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgShow2;
        private System.Windows.Forms.GroupBox groupTurn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Papiloo.PCalander pCalander1;
        private System.Windows.Forms.Button btnSetDate;
    }
}