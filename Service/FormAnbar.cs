using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PopupControl;
using Papiloo;

namespace Service
{
    public partial class FormAnbar : Form
    {
        public FormAnbar()
        {
            InitializeComponent();
        }
        Popup popup;
        StimulsoftEntities context = new StimulsoftEntities();
        //public string majhool1 = "",majhool2="";
        public void Add_Parent_Prodoct()
        {
            try
            {
                AnbarParent parent = new AnbarParent();
                parent.Case = comCase.SelectedIndex;
                parent.Date = int.Parse(Date.Text.Replace("/", ""));
                parent.Description = txtDetails.Text;
                context.AnbarParent.Add(parent);
                context.SaveChanges();
                //------
                groupProdoct.Enabled = true;
                txtCodeProdoct.Focus();
                txtCodeProdoct.ForeColor = Color.Black;
                //-----
                if (context.Anbar.Count() > 0)
                {
                    int endCodeRahgiri = int.Parse(context.Anbar.LastOrDefault().CodeRahgiri.ToString());
                    endCodeRahgiri++;
                    lblCodeRahgiri.Text = endCodeRahgiri.ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        } // ezafe kardane faktore jadid be jadvale AnbarParent
        public void Refresh_dgProdoct() // update kardane maghadire dgProdoct
        {
            using (var context1 = new StimulsoftEntities())
            {
                if (context1.AnbarProdoct.Count() > 0)
                {
                    dgProdoct.DataSource = context1.AnbarProdoct.ToList();
                    dgProdoct.Columns[0].Visible = false;
                    dgProdoct.Columns[1].Visible = false;
                    dgProdoct.Columns[2].HeaderText = "نام کالا";
                    dgProdoct.Columns[3].HeaderText = "کد کالا";
                    dgProdoct.Columns[4].HeaderText = "توضیحات";
                    dgProdoct.Columns[5].HeaderText = "بارکد";
                    dgProdoct.Columns[6].HeaderText = "تگ شناسایی";
                    dgProdoct.Columns[7].Visible = false;
                    dgProdoct.Columns[8].Visible = false;

                }
                dgProdoct.DefaultCellStyle.Font = new Font("Tahoma", 8);
                dgProdoct.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8);

            }
        }
        public void Refresh_dgStore()
        {
            using (var context1 = new StimulsoftEntities())
            {
                if (context1.Store.Count() > 0)
                {

                    dgStore.DataSource = context1.Store.ToList();
                    dgStore.Columns[0].Visible = false;
                    dgStore.Columns[1].HeaderText = "فروشگاه یا فرد";
                    dgStore.Columns[1].Width = 100;
                    dgStore.Columns[2].HeaderText = "تلفن";
                    dgStore.Columns[3].HeaderText = "آدرس";
                    dgStore.Columns[4].Visible = false;
                    //MessageBox.Show("anjam shod");
                }
                dgStore.DefaultCellStyle.Font = new Font("Tahoma", 8);
                dgStore.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 8);
            }

        }// update kardane maghadire dgStore
        private void btnNew_Click(object sender, EventArgs e)
        {
            Add_Parent_Prodoct();
        }

        private void FormAnbar_Load(object sender, EventArgs e)
        {
            Date.Text = Practical.Today_Date();
            comCase.SelectedIndex = 0;
            dgAnbar.Enabled = false;
            //groupProdoct.Enabled = false;
            //dateExpird.Text = Practical.Today_Date();
            dateExpird.ForeColor = Color.DarkGray;
            dateExpird.Text = "تاریخ انقضا";
            Refresh_dgProdoct();
            Refresh_dgStore();

            dgProdoct.ClearSelection();
            dgStore.ClearSelection();
        }

        private void dgAnbar_Enter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgAnbar_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        public string[] prodoct() // gereftane maghadir baraye ezafe kardane prodoct
        {
            string[] prodoct1;
            if (dgProdoct.SelectedRows.Count>0)
            {
                MessageBox.Show("محصول را انتخاب کنید", "انتخاب", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prodoct1 = new string[] { "-1" };
                return prodoct1;
            }
                if (dgStore.SelectedRows.Count>0)
            { 
                MessageBox.Show("فروشگاه یا فرد را انتخاب کنید", "انتخاب", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prodoct1 = new string[] { "-1" };
                return prodoct1;
            }
            if (txtSomeProdoct.Text=="" || txtSomeProdoct.Text=="مقدار")
            { 
                MessageBox.Show("مقدار را وارد کنید", "انتخاب", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prodoct1 = new string[] { "-1" };
                return prodoct1;
            }
            if (txtPriceProdoct.Text == "" || txtPriceProdoct.Text== "قیمت")
            { 
                MessageBox.Show("قیمت را وارد کنید", "انتخاب", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prodoct1 = new string[] { "-1" };
                return prodoct1;
            }
            if (dateExpird.Text=="" || dateExpird.Text== "تاریخ انقضا")
            { 
                MessageBox.Show("تاریخ را انتخاب کنید", "انتخاب", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prodoct1 = new string[] { "-1" };
                return prodoct1;
            }
            prodoct1 = new string[] {dgProdoct.CurrentRow.Cells[3].Value.ToString() ,dgProdoct.CurrentRow.Cells[3].Value.ToString()  ,
                dgStore.CurrentRow.Cells[1].Value.ToString() ,
            txtSomeProdoct.Text , txtPriceProdoct.Text , txtDetailProdoct.Text , dateExpird.Text };
            return prodoct1;
        }

        private void btnSaveProdoct_Click(object sender, EventArgs e)
        {
            try
            {
                
                string[] pro = prodoct();
                if (pro[0] != "-1")
                {
                    dgAnbar.Rows.Add(pro[0], pro[1], pro[2], pro[3], pro[4], pro[5], pro[6]);
                    dgAnbar.Enabled = true;
                }
                //------
                //Anbar newProdoct = new Anbar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtCodeProdoct_TextChanged(object sender, EventArgs e)
        {
            if (context.AnbarProdoct.Count() > 0)
            {
                if (txtCodeProdoct.TextLength <= 0)
                {
                    dgProdoct.DataSource = context.AnbarProdoct.ToList();
                }
                else
                {
                    long x = long.Parse(txtCodeProdoct.Text);
                    var selectProdoct = context.AnbarProdoct.Where(c => c.Code == x).ToList();
                    dgProdoct.DataSource = selectProdoct;
                }
                dgProdoct.Columns[0].Visible = false;
                dgProdoct.Columns[1].Visible = false;
                dgProdoct.Columns[2].HeaderText = "نام کالا";
                dgProdoct.Columns[3].HeaderText = "کد کالا";
                dgProdoct.Columns[4].HeaderText = "توضیحات";
                dgProdoct.Columns[5].HeaderText = "بارکد";
                dgProdoct.Columns[6].HeaderText = "تگ شناسایی";
                dgProdoct.Columns[7].Visible = false;
                dgProdoct.Columns[8].Visible = false;
            }
        }

        private void txtCodeProdoct_Enter(object sender, EventArgs e)
        {
            if (txtCodeProdoct.Text == "کد کالا")
            {
                txtCodeProdoct.Text = "";
                txtCodeProdoct.ForeColor = Color.Black;
            }
        }

        private void txtCodeProdoct_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtCodeProdoct_Leave(object sender, EventArgs e)
        {
            if (txtCodeProdoct.Text == "")
            {
                txtCodeProdoct.Text = "";
                //txtCodeProdoct.ForeColor = Color.DarkGray;
                //txtCodeProdoct.Text = "کدکالا";
            }
        }

        private void txtNameProdoct_Enter(object sender, EventArgs e)
        {
            if (txtNameProdoct.Text == "نام کالا")
            {
                txtNameProdoct.ForeColor = Color.Black;
                txtNameProdoct.Text = "";
            }
        }

        private void txtNameProdoct_Leave(object sender, EventArgs e)
        {
            if (txtNameProdoct.Text == "")
            {
                txtCodeProdoct.Text = "";
                //txtNameProdoct.ForeColor = Color.DarkGray;
                //txtNameProdoct.Text = "نام کالا";
            }
        }

        private void txtStoreProdoct_Leave(object sender, EventArgs e)
        {
            if (txtNameStore.Text == "")
            {
                txtNameStore.ForeColor = Color.DarkGray;
                txtNameStore.Text = "نام فروشگاه یا فرد";
            }
        }

        private void txtStoreProdoct_Enter(object sender, EventArgs e)
        {
            if (txtNameStore.Text == "نام فروشگاه یا فرد")
            {
                txtNameStore.ForeColor = Color.Black;
                txtNameStore.Text = "";
            }
        }

        private void txtSomeProdoct_Enter(object sender, EventArgs e)
        {
            if (txtSomeProdoct.Text == "مقدار")
            {
                txtSomeProdoct.ForeColor = Color.Black;
                txtSomeProdoct.Text = "";
            }
        }

        private void txtSomeProdoct_Leave(object sender, EventArgs e)
        {
            if (txtSomeProdoct.Text == "")
            {
                txtSomeProdoct.ForeColor = Color.DarkGray;
                txtSomeProdoct.Text = "مقدار";
            }
        }

        private void txtPriceProdoct_Leave(object sender, EventArgs e)
        {
            if (txtPriceProdoct.Text == "")
            {
                txtPriceProdoct.ForeColor = Color.DarkGray;
                txtPriceProdoct.Text = "قیمت";
            }
        }

        private void txtPriceProdoct_Enter(object sender, EventArgs e)
        {
            if (txtPriceProdoct.Text == "قیمت")
            {
                txtPriceProdoct.ForeColor = Color.Black;
                txtPriceProdoct.Text = "";
            }
        }

        private void txtDetailProdoct_Enter(object sender, EventArgs e)
        {
            if (txtDetailProdoct.Text == "توضیحات")
            {
                txtDetailProdoct.ForeColor = Color.Black;
                txtDetailProdoct.Text = "";
            }
        }

        private void txtDetailProdoct_Leave(object sender, EventArgs e)
        {
            if (txtDetailProdoct.Text == "")
            {
                txtDetailProdoct.ForeColor = Color.DarkGray;
                txtDetailProdoct.Text = "توضیحات";
            }
        }

        private void dateExpird_Enter(object sender, EventArgs e)
        {
            if (dateExpird.Text == "تاریخ انقضا")
            {
                dateExpird.ForeColor = Color.Black;
                dateExpird.Text = "";
            }
        }

        private void dateExpird_Leave(object sender, EventArgs e)
        {
            if (dateExpird.Text == "")
            {
                dateExpird.ForeColor = Color.DarkGray;
                dateExpird.Text = "تاریخ انقضا";
            }
        }

        private void txtCodeProdoct_Click(object sender, EventArgs e)
        {
            txtCodeProdoct.Text = "";
            txtCodeProdoct.ForeColor = Color.Black;
        }

        private void txtCodeProdoct_KeyPress(object sender, KeyPressEventArgs e)
        {
            Practical.Enter_Number(sender, e);
        }

        private void btnAddColleague_Click(object sender, EventArgs e)
        {
            FormLittelEnter frmLitteleEnter = new FormLittelEnter();
            frmLitteleEnter.see = 3;
            frmLitteleEnter.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormLittelEnter frmlittleEnter = new FormLittelEnter();
            frmlittleEnter.see = 2;
            frmlittleEnter.ShowDialog();
        }

        private void btnDelColleague_Click(object sender, EventArgs e)
        {
        }
        private void popup_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            //S_Date.Text = PCalander.Pc_Date;
        }

        private void ucButton1_Load(object sender, EventArgs e)
        {
        }

        private void ucAddStore_Load(object sender, EventArgs e)
        {
            ucAddStore.btn.Text = "+";
            ucAddStore.btn.BackColor = Color.Green;
            ucAddStore.show = "store";
        }

        private void ucDelStore_Load(object sender, EventArgs e)
        {
            ucDelStore.btn.Text = "+";
            ucDelStore.btn.BackColor = Color.Green;
            ucDelStore.show = "prodoct";
        }

        private void txtNameStore_TextChanged(object sender, EventArgs e)
        {
            StimulsoftEntities context = new StimulsoftEntities();
            if (txtNameStore.Text != "")
            {
                var selectStore = context.Store.Where(c => c.Name.Contains(txtNameStore.Text)).ToList();
                dgStore.DataSource = selectStore;
            }
            else
            {
                dgStore.DataSource = context.Store.ToList();
            }
        }

        private void txtNameProdoct_TextChanged(object sender, EventArgs e)
        {
            if (context.AnbarProdoct.Count() > 0)
            {              
               if(txtNameProdoct.TextLength>0)
                {      
                    var selectProdoct = context.AnbarProdoct.Where(c => c.Name.Contains(txtNameProdoct.Text)).ToList();
                    dgProdoct.DataSource = selectProdoct;
                }
                dgProdoct.Columns[0].Visible = false;
                dgProdoct.Columns[1].Visible = false;
                dgProdoct.Columns[2].HeaderText = "نام کالا";
                dgProdoct.Columns[3].HeaderText = "کد کالا";
                dgProdoct.Columns[4].HeaderText = "توضیحات";
                dgProdoct.Columns[5].HeaderText = "بارکد";
                dgProdoct.Columns[6].HeaderText = "تگ شناسایی";
                dgProdoct.Columns[7].Visible = false;
                dgProdoct.Columns[8].Visible = false;
            }
        }
    
        

        private void btnRefreshDgProdoct_Click(object sender, EventArgs e)
        {
            Refresh_dgProdoct();
        }

        private void btnRefreshDgStore_Click(object sender, EventArgs e)
        {
            Refresh_dgStore();
        }

        private void btnDelProdoct_Click(object sender, EventArgs e)
        {
            if(dgProdoct.Rows.Count>0)
            {
                if (dgProdoct.CurrentRow != null)
                {
                    int id = int.Parse(dgProdoct.CurrentRow.Cells[0].Value.ToString());
                    DialogResult result = MessageBox.Show("آیا از حذف محصول مطئن هستید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        var selectProdoct = context.AnbarProdoct.Where(c => c.Id == id).FirstOrDefault();
                        context.AnbarProdoct.Remove(selectProdoct);
                        context.SaveChanges();
                        Refresh_dgProdoct();
                    }
                }
            }
        }

        private void btnDelStore_Click(object sender, EventArgs e)
        {
            if (dgStore.Rows.Count > 0 && dgStore.CurrentRow != null)
            {

                int id = int.Parse(dgStore.CurrentRow.Cells[0].Value.ToString());
                DialogResult result = MessageBox.Show("آیا از حذف فروشگاه مطئن هستید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var selectStore = context.Store.Where(c => c.Id == id).FirstOrDefault();
                    context.Store.Remove(selectStore);
                    context.SaveChanges();
                    Refresh_dgStore();
                }
            }
        }

        private void ucEditButton_Load(object sender, EventArgs e)
        {


        }

        private void ucEditPtodoct_Click(object sender, EventArgs e)
        {
            //ucAddProdoctStore prodoctStore = new ucAddProdoctStore();
            ucAddProdoctStore prodoct = new ucAddProdoctStore();


        }

        private void btnEditProdoct_Click(object sender, EventArgs e)
        {
            if (dgProdoct.SelectedRows.Count == 1)
            {
                FormLittelEnter frmLittelEnter = new FormLittelEnter();
                frmLittelEnter.Text = "ویرایش محصول";
                if (dgProdoct.SelectedRows.Count == 1)
                {
                    frmLittelEnter.majhool = new string[]{
                    "editProdoct",  //frmLittelEnter.prodoct[0] = "2";
                    dgProdoct.CurrentRow.Cells[0].Value.ToString(), // dadane id meghdare entekhab shode
                    dgProdoct.CurrentRow.Cells[1].Value.ToString(), // dadane meghdare unit entekhab shode
                    dgProdoct.CurrentRow.Cells[2].Value.ToString(),
                    dgProdoct.CurrentRow.Cells[3].Value.ToString(),
                    dgProdoct.CurrentRow.Cells[4].Value.ToString(),
                    dgProdoct.CurrentRow.Cells[5].Value.ToString(),
                    dgProdoct.CurrentRow.Cells[6].Value.ToString(),
                };
                    frmLittelEnter.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("یک مورد را انتخاب کنید", "ویرایش", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //frmLittelEnter.majhool[1]= dgProdoct.CurrentRow.Cells[0].Value.ToString(); 
            //frmLittelEnter.majhool[2] = dgProdoct.CurrentRow.Cells[1].Value.ToString(); 
            //frmLittelEnter.majhool[3] = dgProdoct.CurrentRow.Cells[2].Value.ToString();
            //frmLittelEnter.majhool[4] = dgProdoct.CurrentRow.Cells[3].Value.ToString();
            //frmLittelEnter.majhool[5] = dgProdoct.CurrentRow.Cells[4].Value.ToString();
            //frmLittelEnter.majhool[6] = dgProdoct.CurrentRow.Cells[5].Value.ToString();

            //frmLittelEnter.see = 2; // baz kardane form baraye virayesh mahsool
            //frmLittelEnter.majhool1 = dgProdoct.CurrentRow.Cells[0].Value.ToString(); // dadane id meghdare entekhab shode
            //frmLittelEnter.majhool2 = dgProdoct.CurrentRow.Cells[1].Value.ToString(); // dadane meghdare unit entekhab shode
            //if (dgProdoct.CurrentRow.Cells[2].Value != null)
            //{
            //    frmLittelEnter.txtNameProdoct.Text = dgProdoct.CurrentRow.Cells[2].Value.ToString();
            //}
            //if (dgProdoct.CurrentRow.Cells[3].Value != null)
            //{
            //    frmLittelEnter.txtCodeProdoct.Text = dgProdoct.CurrentRow.Cells[3].Value.ToString();
            //}
            //if (dgProdoct.CurrentRow.Cells[4].Value != null)
            //{
            //    frmLittelEnter.txtDetails.Text = dgProdoct.CurrentRow.Cells[4].Value.ToString();
            //}
            //if (dgProdoct.CurrentRow.Cells[5].Value != null)
            //{
            //    frmLittelEnter.txtCodeProdoct.Text = dgProdoct.CurrentRow.Cells[5].Value.ToString();
            //}
            //frmLittelEnter.ShowDialog();
        
        }
        //public string id, name, code, unit, description, barcod, rfid;

        //private void dgProdoct_DoubleClick(object sender, EventArgs e)
        //{
        //    id = dgProdoct.CurrentRow.Cells[0].Value.ToString();
        //    unit = dgProdoct.CurrentRow.Cells[1].Value.ToString();
        //    name = dgProdoct.CurrentRow.Cells[2].Value.ToString();
        //    code = dgProdoct.CurrentRow.Cells[3].Value.ToString();
        //    description = dgProdoct.CurrentRow.Cells[4].Value.ToString();
        //    barcod = dgProdoct.CurrentRow.Cells[5].Value.ToString();
        //    rfid = dgProdoct.CurrentRow.Cells[6].Value.ToString();
        //}

        //private void ucEditProdoct_Click(object sender, EventArgs e)
        //{
        //    ucEditProdoct.id = id;
        //    ucEditProdoct.unit = unit;
        //    ucEditProdoct.name = name;
        //    ucEditProdoct.code = code;
        //    ucEditProdoct.detail = description;
        //    ucEditProdoct.barcode = barcod;
        //    ucEditProdoct.rfid = rfid;
        //    ucEditProdoct.show = "editProdoct";
        //}

        private void dgProdoct_Enter(object sender, EventArgs e)
        {

        }

        private void btnEditStore_Click(object sender, EventArgs e)
        {
            if(dgStore.SelectedRows.Count ==1)
            {
                FormLittelEnter frmLittelEnter = new FormLittelEnter();
                frmLittelEnter.Text = "ویرایش فروشگاه یا فرد";
                frmLittelEnter.majhool = new string[]{
                "editStore",
                dgStore.CurrentRow.Cells[0].Value.ToString(),
                dgStore.CurrentRow.Cells[1].Value.ToString(),
                dgStore.CurrentRow.Cells[2].Value.ToString(),
                dgStore.CurrentRow.Cells[3].Value.ToString()
                    };
                frmLittelEnter.ShowDialog();
            }
            else
            {
                MessageBox.Show("یک مورد را انتخاب کنید", "ویرایش", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}


