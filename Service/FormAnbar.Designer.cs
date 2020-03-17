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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAnbar));
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
            this.txtNameStore = new System.Windows.Forms.TextBox();
            this.txtSomeProdoct = new System.Windows.Forms.TextBox();
            this.txtPriceProdoct = new System.Windows.Forms.TextBox();
            this.btnSaveProdoct = new System.Windows.Forms.Button();
            this.groupProdoct = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnAddColleague = new System.Windows.Forms.Button();
            this.btnDelColleague = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgStore = new System.Windows.Forms.DataGridView();
            this.txtCodeStore = new System.Windows.Forms.TextBox();
            this.dgProdoct = new System.Windows.Forms.DataGridView();
            this.lblCodeRahgiri = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateExpird = new PapilooDate.FDate();
            this.Date = new PapilooDate.FDate();
            this.ucAddStore = new Papiloo.ucButton();
            this.ucDelStore = new Papiloo.ucButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnbar)).BeginInit();
            this.groupProdoct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdoct)).BeginInit();
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
            this.dgAnbar.Location = new System.Drawing.Point(7, 317);
            this.dgAnbar.Name = "dgAnbar";
            this.dgAnbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgAnbar.Size = new System.Drawing.Size(949, 324);
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
            this.txtDetailProdoct.Location = new System.Drawing.Point(136, 133);
            this.txtDetailProdoct.Name = "txtDetailProdoct";
            this.txtDetailProdoct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDetailProdoct.Size = new System.Drawing.Size(262, 26);
            this.txtDetailProdoct.TabIndex = 39;
            this.txtDetailProdoct.Text = "توضیحات";
            this.txtDetailProdoct.Enter += new System.EventHandler(this.txtDetailProdoct_Enter);
            this.txtDetailProdoct.Leave += new System.EventHandler(this.txtDetailProdoct_Leave);
            // 
            // txtCodeProdoct
            // 
            this.txtCodeProdoct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCodeProdoct.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCodeProdoct.Location = new System.Drawing.Point(855, 22);
            this.txtCodeProdoct.Name = "txtCodeProdoct";
            this.txtCodeProdoct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCodeProdoct.Size = new System.Drawing.Size(84, 26);
            this.txtCodeProdoct.TabIndex = 34;
            this.txtCodeProdoct.Text = "کد کالا";
            this.txtCodeProdoct.Click += new System.EventHandler(this.txtCodeProdoct_Click);
            this.txtCodeProdoct.TabIndexChanged += new System.EventHandler(this.txtCodeProdoct_TabIndexChanged);
            this.txtCodeProdoct.TextChanged += new System.EventHandler(this.txtCodeProdoct_TextChanged);
            this.txtCodeProdoct.Enter += new System.EventHandler(this.txtCodeProdoct_Enter);
            this.txtCodeProdoct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeProdoct_KeyPress);
            this.txtCodeProdoct.Leave += new System.EventHandler(this.txtCodeProdoct_Leave);
            // 
            // txtNameProdoct
            // 
            this.txtNameProdoct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNameProdoct.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNameProdoct.Location = new System.Drawing.Point(443, 22);
            this.txtNameProdoct.Name = "txtNameProdoct";
            this.txtNameProdoct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNameProdoct.Size = new System.Drawing.Size(159, 26);
            this.txtNameProdoct.TabIndex = 35;
            this.txtNameProdoct.Text = "نام کالا";
            this.txtNameProdoct.Enter += new System.EventHandler(this.txtNameProdoct_Enter);
            this.txtNameProdoct.Leave += new System.EventHandler(this.txtNameProdoct_Leave);
            // 
            // txtNameStore
            // 
            this.txtNameStore.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNameStore.ForeColor = System.Drawing.Color.DarkGray;
            this.txtNameStore.Location = new System.Drawing.Point(694, 22);
            this.txtNameStore.Name = "txtNameStore";
            this.txtNameStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNameStore.Size = new System.Drawing.Size(159, 26);
            this.txtNameStore.TabIndex = 36;
            this.txtNameStore.Text = "نام فروشگاه یا فرد";
            this.txtNameStore.Enter += new System.EventHandler(this.txtStoreProdoct_Enter);
            this.txtNameStore.Leave += new System.EventHandler(this.txtStoreProdoct_Leave);
            // 
            // txtSomeProdoct
            // 
            this.txtSomeProdoct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtSomeProdoct.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSomeProdoct.Location = new System.Drawing.Point(349, 69);
            this.txtSomeProdoct.Name = "txtSomeProdoct";
            this.txtSomeProdoct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSomeProdoct.Size = new System.Drawing.Size(49, 26);
            this.txtSomeProdoct.TabIndex = 37;
            this.txtSomeProdoct.Text = "مقدار";
            this.txtSomeProdoct.Enter += new System.EventHandler(this.txtSomeProdoct_Enter);
            this.txtSomeProdoct.Leave += new System.EventHandler(this.txtSomeProdoct_Leave);
            // 
            // txtPriceProdoct
            // 
            this.txtPriceProdoct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPriceProdoct.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPriceProdoct.Location = new System.Drawing.Point(297, 101);
            this.txtPriceProdoct.Name = "txtPriceProdoct";
            this.txtPriceProdoct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPriceProdoct.Size = new System.Drawing.Size(101, 26);
            this.txtPriceProdoct.TabIndex = 38;
            this.txtPriceProdoct.Text = "قیمت";
            this.txtPriceProdoct.Enter += new System.EventHandler(this.txtPriceProdoct_Enter);
            this.txtPriceProdoct.Leave += new System.EventHandler(this.txtPriceProdoct_Leave);
            // 
            // btnSaveProdoct
            // 
            this.btnSaveProdoct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSaveProdoct.Location = new System.Drawing.Point(5, 23);
            this.btnSaveProdoct.Name = "btnSaveProdoct";
            this.btnSaveProdoct.Size = new System.Drawing.Size(54, 29);
            this.btnSaveProdoct.TabIndex = 41;
            this.btnSaveProdoct.Text = "ثبت";
            this.btnSaveProdoct.UseVisualStyleBackColor = true;
            this.btnSaveProdoct.Click += new System.EventHandler(this.btnSaveProdoct_Click);
            // 
            // groupProdoct
            // 
            this.groupProdoct.Controls.Add(this.ucDelStore);
            this.groupProdoct.Controls.Add(this.ucAddStore);
            this.groupProdoct.Controls.Add(this.button2);
            this.groupProdoct.Controls.Add(this.button3);
            this.groupProdoct.Controls.Add(this.button4);
            this.groupProdoct.Controls.Add(this.btnAddColleague);
            this.groupProdoct.Controls.Add(this.btnDelColleague);
            this.groupProdoct.Controls.Add(this.button1);
            this.groupProdoct.Controls.Add(this.dgStore);
            this.groupProdoct.Controls.Add(this.txtCodeStore);
            this.groupProdoct.Controls.Add(this.dgProdoct);
            this.groupProdoct.Controls.Add(this.lblCodeRahgiri);
            this.groupProdoct.Controls.Add(this.label1);
            this.groupProdoct.Controls.Add(this.txtNameProdoct);
            this.groupProdoct.Controls.Add(this.dateExpird);
            this.groupProdoct.Controls.Add(this.btnSaveProdoct);
            this.groupProdoct.Controls.Add(this.txtDetailProdoct);
            this.groupProdoct.Controls.Add(this.txtPriceProdoct);
            this.groupProdoct.Controls.Add(this.txtCodeProdoct);
            this.groupProdoct.Controls.Add(this.txtSomeProdoct);
            this.groupProdoct.Controls.Add(this.txtNameStore);
            this.groupProdoct.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupProdoct.Location = new System.Drawing.Point(7, 73);
            this.groupProdoct.Name = "groupProdoct";
            this.groupProdoct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupProdoct.Size = new System.Drawing.Size(946, 238);
            this.groupProdoct.TabIndex = 42;
            this.groupProdoct.TabStop = false;
            this.groupProdoct.Text = "اضافه کردن کلا";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(897, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 23);
            this.button2.TabIndex = 94;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(849, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 23);
            this.button3.TabIndex = 95;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(801, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 23);
            this.button4.TabIndex = 93;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnAddColleague
            // 
            this.btnAddColleague.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddColleague.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddColleague.Location = new System.Drawing.Point(142, 203);
            this.btnAddColleague.Name = "btnAddColleague";
            this.btnAddColleague.Size = new System.Drawing.Size(42, 23);
            this.btnAddColleague.TabIndex = 91;
            this.btnAddColleague.Text = "+";
            this.btnAddColleague.UseVisualStyleBackColor = false;
            this.btnAddColleague.Click += new System.EventHandler(this.btnAddColleague_Click);
            // 
            // btnDelColleague
            // 
            this.btnDelColleague.BackColor = System.Drawing.Color.Red;
            this.btnDelColleague.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelColleague.Location = new System.Drawing.Point(94, 203);
            this.btnDelColleague.Name = "btnDelColleague";
            this.btnDelColleague.Size = new System.Drawing.Size(42, 23);
            this.btnDelColleague.TabIndex = 92;
            this.btnDelColleague.Text = "-";
            this.btnDelColleague.UseVisualStyleBackColor = false;
            this.btnDelColleague.Click += new System.EventHandler(this.btnDelColleague_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(46, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 23);
            this.button1.TabIndex = 50;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgStore
            // 
            this.dgStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStore.Location = new System.Drawing.Point(443, 54);
            this.dgStore.Name = "dgStore";
            this.dgStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgStore.Size = new System.Drawing.Size(245, 146);
            this.dgStore.TabIndex = 46;
            // 
            // txtCodeStore
            // 
            this.txtCodeStore.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCodeStore.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCodeStore.Location = new System.Drawing.Point(604, 22);
            this.txtCodeStore.Name = "txtCodeStore";
            this.txtCodeStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCodeStore.Size = new System.Drawing.Size(84, 26);
            this.txtCodeStore.TabIndex = 45;
            this.txtCodeStore.Text = "کد فروشگاه";
            // 
            // dgProdoct
            // 
            this.dgProdoct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdoct.Location = new System.Drawing.Point(694, 54);
            this.dgProdoct.Name = "dgProdoct";
            this.dgProdoct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgProdoct.Size = new System.Drawing.Size(245, 146);
            this.dgProdoct.TabIndex = 44;
            // 
            // lblCodeRahgiri
            // 
            this.lblCodeRahgiri.AutoSize = true;
            this.lblCodeRahgiri.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeRahgiri.Location = new System.Drawing.Point(65, 64);
            this.lblCodeRahgiri.Name = "lblCodeRahgiri";
            this.lblCodeRahgiri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCodeRahgiri.Size = new System.Drawing.Size(65, 18);
            this.lblCodeRahgiri.TabIndex = 43;
            this.lblCodeRahgiri.Text = "تاریخ ورود";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 42;
            this.label1.Text = "کد رهگیری:";
            // 
            // dateExpird
            // 
            this.dateExpird.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dateExpird.Location = new System.Drawing.Point(64, 23);
            this.dateExpird.Name = "dateExpird";
            this.dateExpird.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateExpird.Size = new System.Drawing.Size(141, 29);
            this.dateExpird.TabIndex = 40;
            this.dateExpird.Enter += new System.EventHandler(this.dateExpird_Enter);
            this.dateExpird.Leave += new System.EventHandler(this.dateExpird_Leave);
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
            // ucAddStore
            // 
            this.ucAddStore.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ucAddStore.Location = new System.Drawing.Point(640, 203);
            this.ucAddStore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucAddStore.Name = "ucAddStore";
            this.ucAddStore.Size = new System.Drawing.Size(48, 26);
            this.ucAddStore.TabIndex = 96;
            this.ucAddStore.Load += new System.EventHandler(this.ucAddStore_Load);
            // 
            // ucDelStore
            // 
            this.ucDelStore.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ucDelStore.Location = new System.Drawing.Point(584, 203);
            this.ucDelStore.Margin = new System.Windows.Forms.Padding(4);
            this.ucDelStore.Name = "ucDelStore";
            this.ucDelStore.Size = new System.Drawing.Size(48, 26);
            this.ucDelStore.TabIndex = 97;
            this.ucDelStore.Load += new System.EventHandler(this.ucDelStore_Load);
            // 
            // FormAnbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 640);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdoct)).EndInit();
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
        private System.Windows.Forms.TextBox txtNameStore;
        private System.Windows.Forms.TextBox txtSomeProdoct;
        private System.Windows.Forms.TextBox txtPriceProdoct;
        private System.Windows.Forms.Button btnSaveProdoct;
        private System.Windows.Forms.GroupBox groupProdoct;
        private System.Windows.Forms.Label lblCodeRahgiri;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCodeProdoct;
        public System.Windows.Forms.TextBox txtNameProdoct;
        public System.Windows.Forms.TextBox txtCodeStore;
        private System.Windows.Forms.DataGridView dgProdoct;
        private System.Windows.Forms.DataGridView dgStore;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button btnAddColleague;
        public System.Windows.Forms.Button btnDelColleague;
        private Papiloo.ucButton ucAddStore;
        private Papiloo.ucButton ucDelStore;
    }
}