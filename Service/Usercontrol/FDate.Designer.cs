﻿namespace ERA
{
    partial class FDate
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FDate));
            this.S_Date = new System.Windows.Forms.MaskedTextBox();
            this.T_Date = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // S_Date
            // 
            this.S_Date.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.S_Date.Location = new System.Drawing.Point(36, 2);
            this.S_Date.Mask = "####/##/##";
            this.S_Date.Name = "S_Date";
            this.S_Date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.S_Date.Size = new System.Drawing.Size(102, 27);
            this.S_Date.TabIndex = 305;
            this.S_Date.TextChanged += new System.EventHandler(this.S_Date_TextChanged);
            // 
            // T_Date
            // 
            this.T_Date.Cursor = System.Windows.Forms.Cursors.Default;
            this.T_Date.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.T_Date.Image = ((System.Drawing.Image)(resources.GetObject("T_Date.Image")));
            this.T_Date.Location = new System.Drawing.Point(2, 2);
            this.T_Date.Name = "T_Date";
            this.T_Date.Size = new System.Drawing.Size(33, 26);
            this.T_Date.TabIndex = 306;
            this.T_Date.TabStop = false;
            this.T_Date.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.T_Date.UseVisualStyleBackColor = true;
            this.T_Date.Click += new System.EventHandler(this.T_Date_Click);
            // 
            // FDate
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.T_Date);
            this.Controls.Add(this.S_Date);
            this.Name = "FDate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(141, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox S_Date;
        private System.Windows.Forms.Button T_Date;



    }
}
