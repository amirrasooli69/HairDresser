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
            this.btnNew = new System.Windows.Forms.Button();
            this.comCase = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.dgAnbar = new System.Windows.Forms.DataGridView();
            this.ProdoctCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdoctName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameStore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDetailProdoct = new System.Windows.Forms.TextBox();
            this.txtCodeProdoct = new System.Windows.Forms.TextBox();
            this.txtNameProdoct = new System.Windows.Forms.TextBox();
            this.txtStoreProdoct = new System.Windows.Forms.TextBox();
            this.txtSomeProdoct = new System.Windows.Forms.TextBox();
            this.txtPriceProdoct = new System.Windows.Forms.TextBox();
            this.btnSaveProdoct = new System.Windows.Forms.Button();
            this.dateExpird = new PapilooDate.FDate();
            this.Date = new PapilooDate.FDate();
            this.groupProdoct = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnbar)).BeginInit();
            this.groupProdoct.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.comCase);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Date);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDetails);
            this.groupBox1.Controls.Add(this.label32);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 66);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnNew.Location = new System.Drawing.Point(5, 22);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(54, 29);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "جدید";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
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
            this.comCase.Location = new System.Drawing.Point(729, 22);
            this.comCase.Name = "comCase";
            this.comCase.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comCase.Size = new System.Drawing.Size(152, 26);
            this.comCase.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(640, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "تاریخ ورود";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(887, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 27;
            this.label2.Text = "عملیات";
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(65, 22);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDetails.Size = new System.Drawing.Size(354, 28);
            this.txtDetails.TabIndex = 3;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(425, 27);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(62, 18);
            this.label32.TabIndex = 18;
            this.label32.Text = "توضیحات";
            // 
            // dgAnbar
            // 
            this.dgAnbar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnbar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdoctCode,
            this.ProdoctName,
            this.NameStore,
            this.Count,
            this.Price,
            this.Description,
            this.DateExpired,
            this.btnDelete});
            this.dgAnbar.Location = new System.Drawing.Point(7, 133);
            this.dgAnbar.Name = "dgAnbar";
            this.dgAnbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgAnbar.Size = new System.Drawing.Size(949, 365);
            this.dgAnbar.TabIndex = 9;
            this.dgAnbar.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAnbar_CellEndEdit);
            this.dgAnbar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgAnbar_KeyPress);
            // 
            // ProdoctCode
            // 
            this.ProdoctCode.HeaderText = "کدکلا";
            this.ProdoctCode.Name = "ProdoctCode";
            // 
            // ProdoctName
            // 
            this.ProdoctName.HeaderText = "نام کالا";
            this.ProdoctName.Name = "ProdoctName";
            // 
            // NameStore
            // 
            this.NameStore.HeaderText = "نام فروشگاه یا فرد";
            this.NameStore.Name = "NameStore";
            this.NameStore.Width = 120;
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
            // Description
            // 
            this.Description.HeaderText = "توضیحات";
            this.Description.Name = "Description";
            this.Description.Width = 200;
            // 
            // DateExpired
            // 
            this.DateExpired.HeaderText = "تاریخ انقصا";
            this.DateExpired.Name = "DateExpired";
            // 
            // btnDelete
            // 
            this.btnDelete.FillWeight = 50F;
            this.btnDelete.HeaderText = "";
            this.btnDelete.Name = "btnDelete";
            // 
            // txtDetailProdoct
            // 
            this.txtDetailProdoct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtDetailProdoct.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDetailProdoct.Location = new System.Drawing.Point(199, 19);
            this.txtDetailProdoct.Name = "txtDetailProdoct";
            this.txtDetailProdoct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDetailProdoct.Size = new System.Drawing.Size(265, 26);
            this.txtDetailProdoct.TabIndex = 39;
            this.txtDetailProdoct.Text = "توضیحات";
            // 
            // txtCodeProdoct
            // 
            this.txtCodeProdoct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCodeProdoct.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCodeProdoct.Location = new System.Drawing.Point(865, 19);
            this.txtCodeProdoct.Name = "txtCodeProdoct";
            this.txtCodeProdoct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCodeProdoct.Size = new System.Drawing.Size(76, 26);
            this.txtCodeProdoct.TabIndex = 34;
            this.txtCodeProdoct.Text = "کد کالا";
            // 
            // txtNameProdoct
            // 
            this.txtNameProdoct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNameProdoct.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNameProdoct.Location = new System.Drawing.Point(760, 19);
            this.txtNameProdoct.Name = "txtNameProdoct";
            this.txtNameProdoct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNameProdoct.Size = new System.Drawing.Size(103, 26);
            this.txtNameProdoct.TabIndex = 35;
            this.txtNameProdoct.Text = "نام کالا";
            // 
            // txtStoreProdoct
            // 
            this.txtStoreProdoct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtStoreProdoct.ForeColor = System.Drawing.Color.DarkGray;
            this.txtStoreProdoct.Location = new System.Drawing.Point(623, 19);
            this.txtStoreProdoct.Name = "txtStoreProdoct";
            this.txtStoreProdoct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStoreProdoct.Size = new System.Drawing.Size(136, 26);
            this.txtStoreProdoct.TabIndex = 36;
            this.txtStoreProdoct.Text = "نام فروشگاه یا فرد";
            // 
            // txtSomeProdoct
            // 
            this.txtSomeProdoct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSomeProdoct.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSomeProdoct.Location = new System.Drawing.Point(571, 19);
            this.txtSomeProdoct.Name = "txtSomeProdoct";
            this.txtSomeProdoct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSomeProdoct.Size = new System.Drawing.Size(49, 26);
            this.txtSomeProdoct.TabIndex = 37;
            this.txtSomeProdoct.Text = "مقدار";
            // 
            // txtPriceProdoct
            // 
            this.txtPriceProdoct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPriceProdoct.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPriceProdoct.Location = new System.Drawing.Point(467, 19);
            this.txtPriceProdoct.Name = "txtPriceProdoct";
            this.txtPriceProdoct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPriceProdoct.Size = new System.Drawing.Size(101, 26);
            this.txtPriceProdoct.TabIndex = 38;
            this.txtPriceProdoct.Text = "قیمت";
            // 
            // btnSaveProdoct
            // 
            this.btnSaveProdoct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveProdoct.Location = new System.Drawing.Point(0, 17);
            this.btnSaveProdoct.Name = "btnSaveProdoct";
            this.btnSaveProdoct.Size = new System.Drawing.Size(57, 29);
            this.btnSaveProdoct.TabIndex = 41;
            this.btnSaveProdoct.Text = "ثبت";
            this.btnSaveProdoct.UseVisualStyleBackColor = true;
            this.btnSaveProdoct.Click += new System.EventHandler(this.btnSaveProdoct_Click);
            // 
            // dateExpird
            // 
            this.dateExpird.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dateExpird.Location = new System.Drawing.Point(58, 16);
            this.dateExpird.Name = "dateExpird";
            this.dateExpird.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateExpird.Size = new System.Drawing.Size(141, 29);
            this.dateExpird.TabIndex = 40;
            // 
            // Date
            // 
            this.Date.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Date.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Date.Location = new System.Drawing.Point(493, 20);
            this.Date.Name = "Date";
            this.Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Date.Size = new System.Drawing.Size(141, 31);
            this.Date.TabIndex = 1;
            // 
            // groupProdoct
            // 
            this.groupProdoct.Controls.Add(this.txtNameProdoct);
            this.groupProdoct.Controls.Add(this.dateExpird);
            this.groupProdoct.Controls.Add(this.btnSaveProdoct);
            this.groupProdoct.Controls.Add(this.txtDetailProdoct);
            this.groupProdoct.Controls.Add(this.txtPriceProdoct);
            this.groupProdoct.Controls.Add(this.txtCodeProdoct);
            this.groupProdoct.Controls.Add(this.txtSomeProdoct);
            this.groupProdoct.Controls.Add(this.txtStoreProdoct);
            this.groupProdoct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupProdoct.Location = new System.Drawing.Point(7, 71);
            this.groupProdoct.Name = "groupProdoct";
            this.groupProdoct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupProdoct.Size = new System.Drawing.Size(946, 55);
            this.groupProdoct.TabIndex = 42;
            this.groupProdoct.TabStop = false;
            this.groupProdoct.Text = "اضافه کردن کلا";
            // 
            // FormAnbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 503);
            this.Controls.Add(this.groupProdoct);
            this.Controls.Add(this.dgAnbar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAnbar";
            this.Text = "انبار";
            this.Load += new System.EventHandler(this.FormAnbar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnbar)).EndInit();
            this.groupProdoct.ResumeLayout(false);
            this.groupProdoct.PerformLayout();
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
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridView dgAnbar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdoctCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdoctName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateExpired;
        private System.Windows.Forms.DataGridViewTextBoxColumn btnDelete;
        private PapilooDate.FDate dateExpird;
        private System.Windows.Forms.TextBox txtDetailProdoct;
        private System.Windows.Forms.TextBox txtCodeProdoct;
        private System.Windows.Forms.TextBox txtNameProdoct;
        private System.Windows.Forms.TextBox txtStoreProdoct;
        private System.Windows.Forms.TextBox txtSomeProdoct;
        private System.Windows.Forms.TextBox txtPriceProdoct;
        private System.Windows.Forms.Button btnSaveProdoct;
        private System.Windows.Forms.GroupBox groupProdoct;
    }
}