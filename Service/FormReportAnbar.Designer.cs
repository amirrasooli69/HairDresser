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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportAnbar));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalExisting = new System.Windows.Forms.Label();
            this.dgSearch = new System.Windows.Forms.DataGridView();
            this.comProdoct = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1084, 579);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = ":موجودی";
            // 
            // lblTotalExisting
            // 
            this.lblTotalExisting.AutoSize = true;
            this.lblTotalExisting.Location = new System.Drawing.Point(939, 579);
            this.lblTotalExisting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalExisting.Name = "lblTotalExisting";
            this.lblTotalExisting.Size = new System.Drawing.Size(44, 18);
            this.lblTotalExisting.TabIndex = 9;
            this.lblTotalExisting.Text = "label1";
            // 
            // dgSearch
            // 
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.Location = new System.Drawing.Point(19, 61);
            this.dgSearch.Margin = new System.Windows.Forms.Padding(4);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgSearch.Size = new System.Drawing.Size(1151, 497);
            this.dgSearch.TabIndex = 8;
            // 
            // comProdoct
            // 
            this.comProdoct.FormattingEnabled = true;
            this.comProdoct.Location = new System.Drawing.Point(659, 17);
            this.comProdoct.Margin = new System.Windows.Forms.Padding(4);
            this.comProdoct.Name = "comProdoct";
            this.comProdoct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comProdoct.Size = new System.Drawing.Size(207, 26);
            this.comProdoct.TabIndex = 7;
            this.comProdoct.SelectedIndexChanged += new System.EventHandler(this.comProdoct_SelectedIndexChanged);
            this.comProdoct.SelectionChangeCommitted += new System.EventHandler(this.comProdoct_SelectionChangeCommitted);
            this.comProdoct.SelectedValueChanged += new System.EventHandler(this.comProdoct_SelectedValueChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(19, 13);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(144, 32);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FormReportAnbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalExisting);
            this.Controls.Add(this.dgSearch);
            this.Controls.Add(this.comProdoct);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormReportAnbar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش انبار";
            this.Load += new System.EventHandler(this.FormReportAnbar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalExisting;
        private System.Windows.Forms.DataGridView dgSearch;
        private System.Windows.Forms.ComboBox comProdoct;
        private System.Windows.Forms.Button btnSearch;
    }
}