namespace Service
{
    partial class FormReportAnbar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalExisting = new System.Windows.Forms.Label();
            this.dgSearch = new System.Windows.Forms.DataGridView();
            this.comProdoct = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 249);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(858, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(813, 418);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = ":موجودی";
            // 
            // lblTotalExisting
            // 
            this.lblTotalExisting.AutoSize = true;
            this.lblTotalExisting.Location = new System.Drawing.Point(704, 418);
            this.lblTotalExisting.Name = "lblTotalExisting";
            this.lblTotalExisting.Size = new System.Drawing.Size(35, 13);
            this.lblTotalExisting.TabIndex = 9;
            this.lblTotalExisting.Text = "label1";
            // 
            // dgSearch
            // 
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.Location = new System.Drawing.Point(14, 54);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgSearch.Size = new System.Drawing.Size(858, 179);
            this.dgSearch.TabIndex = 8;
            // 
            // comProdoct
            // 
            this.comProdoct.FormattingEnabled = true;
            this.comProdoct.Location = new System.Drawing.Point(365, 6);
            this.comProdoct.Name = "comProdoct";
            this.comProdoct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comProdoct.Size = new System.Drawing.Size(156, 21);
            this.comProdoct.TabIndex = 7;
            this.comProdoct.SelectedIndexChanged += new System.EventHandler(this.comProdoct_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(208, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormReportAnbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 442);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalExisting);
            this.Controls.Add(this.dgSearch);
            this.Controls.Add(this.comProdoct);
            this.Controls.Add(this.btnSearch);
            this.Name = "FormReportAnbar";
            this.Text = "FormReportAnbar";
            this.Load += new System.EventHandler(this.FormReportAnbar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalExisting;
        private System.Windows.Forms.DataGridView dgSearch;
        private System.Windows.Forms.ComboBox comProdoct;
        private System.Windows.Forms.Button btnSearch;
    }
}