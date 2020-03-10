namespace Service
{
    partial class FormAnbar
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comCase = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.dgAnbar = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateBuild = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateExpierd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdParent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.btnNew = new System.Windows.Forms.Button();
            this.Date = new PapilooDate.FDate();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnbar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comCase);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDetails);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Location = new System.Drawing.Point(12, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(905, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // comCase
            // 
            this.comCase.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comCase.FormattingEnabled = true;
            this.comCase.Items.AddRange(new object[] {
            "رسید(خرید)",
            "حواله(فروش)",
            "حواله(مصرف)",
            "رسید(تولید)"});
            this.comCase.Location = new System.Drawing.Point(679, 22);
            this.comCase.Name = "comCase";
            this.comCase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comCase.Size = new System.Drawing.Size(162, 26);
            this.comCase.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(602, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "تاریخ ورود";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(847, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "عملیات";
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(69, 22);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDetails.Size = new System.Drawing.Size(312, 28);
            this.txtDetails.TabIndex = 3;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(387, 25);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(62, 18);
            this.label32.TabIndex = 18;
            this.label32.Text = "توضیحات";
            // 
            // dgAnbar
            // 
            this.dgAnbar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnbar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Count,
            this.Price,
            this.IdStore,
            this.Description,
            this.DateBuild,
            this.DateExpierd,
            this.IdParent,
            this.Id});
            this.dgAnbar.Enabled = false;
            this.dgAnbar.Location = new System.Drawing.Point(12, 76);
            this.dgAnbar.Name = "dgAnbar";
            this.dgAnbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgAnbar.Size = new System.Drawing.Size(905, 338);
            this.dgAnbar.TabIndex = 5;
            // 
            // Name
            // 
            this.Name.HeaderText = "نام";
            this.Name.Name = "Name";
            // 
            // Count
            // 
            this.Count.HeaderText = "تعداد";
            this.Count.Name = "Count";
            // 
            // Price
            // 
            this.Price.HeaderText = "قیمت";
            this.Price.Name = "Price";
            // 
            // IdStore
            // 
            this.IdStore.HeaderText = "کد فروشگاه یا فرد";
            this.IdStore.Name = "IdStore";
            this.IdStore.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.Width = 300;
            // 
            // DateBuild
            // 
            this.DateBuild.HeaderText = "تاریخ ساخت";
            this.DateBuild.Name = "DateBuild";
            // 
            // DateExpierd
            // 
            this.DateExpierd.HeaderText = "تاریخ انقضا";
            this.DateExpierd.Name = "DateExpierd";
            // 
            // IdParent
            // 
            this.IdParent.HeaderText = "شماره سند";
            this.IdParent.Name = "IdParent";
            // 
            // Id
            // 
            this.Id.HeaderText = "شماره";
            this.Id.Name = "Id";
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(18, 23);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(57, 32);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "جدید";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Date
            // 
            this.Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Date.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Date.Location = new System.Drawing.Point(455, 20);
            this.Date.Name = "Date";
            this.Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date.Size = new System.Drawing.Size(141, 31);
            this.Date.TabIndex = 1;
            // 
            // FormAnbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 418);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgAnbar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAnbar";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انبار";
            this.Load += new System.EventHandler(this.FormAnbar_Load);
            this.Click += new System.EventHandler(this.FormAnbar_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comCase;
        private System.Windows.Forms.Label label4;
        private PapilooDate.FDate Date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridView dgAnbar;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateBuild;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateExpierd;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdParent;
        private Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewLabelXColumn Id;
    }
}