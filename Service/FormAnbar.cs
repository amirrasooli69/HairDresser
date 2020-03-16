using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PapilooDate;
using System.Threading;

namespace Service
{
    public partial class FormAnbar : Form
    {
        public FormAnbar()
        {
            InitializeComponent();
        }
        StimulsoftEntities context = new StimulsoftEntities();
        //public string majhool1 = "",majhool2="";
        public void  Add_Parent_Prodoct()
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
        }
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
        }

        private void dgAnbar_Enter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgAnbar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgAnbar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string[] prodoct()
        {
            string[] prodoct1 = {txtCodeProdoct.Text , txtNameProdoct.Text , txtNameStore.Text ,
            txtSomeProdoct.Text , txtPriceProdoct.Text , txtDetailProdoct.Text , dateExpird.Text };
            return prodoct1;
        }
        private void newProdoct1_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveProdoct_Click(object sender, EventArgs e)
        {
            try
            {
                string[] pro = prodoct();
                dgAnbar.Rows.Add(pro[0], pro[1], pro[2], pro[3], pro[4], pro[5], pro[6]);
                dgAnbar.Enabled = true;
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
            
        }

        private void txtCodeProdoct_Enter(object sender, EventArgs e)
        {
            if (txtCodeProdoct.Text == "کد کالا")
            {
                txtCodeProdoct.Text = "";
            }
        }

        private void txtCodeProdoct_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodeProdoct_Leave(object sender, EventArgs e)
        {
            if (context.AnbarProdoct.Count() > 0)
            {
                if (txtCodeProdoct.Text == "" || txtCodeProdoct == null)
                {
                    FormLittelEnter frmlittel = new FormLittelEnter();
                    //frmlittel.panelProdoct.Visible = true;
                    //frmlittel.panelStore.Visible = false;
                    //frmlittel.panelProdoct.Dock = DockStyle.Fill;
                    //frmlittel.dgSearch.DataSource = context.AnbarProdoct.ToList();
                    //frmlittel.ShowDialog();
                    frmlittel.see = 2;
                    frmlittel.ShowDialog();
                    //txtStoreProdoct.Focus();
                    //txtCodeProdoct.Text = majhool1;
                    //txtNameProdoct.Text = majhool2;



                }
                else
                {
                    if (char.IsDigit(txtCodeProdoct.Text, 0))
                    {
                        Int32 x = int.Parse(txtCodeProdoct.Text);
                        var search = context.AnbarProdoct.Where(c => c.Code == x).FirstOrDefault();
                        if (search != null)
                        {
                            txtNameProdoct.Text = search.Name;
                            txtNameStore.Focus();
                        }
                        if (search == null)
                        {
                            FormLittelEnter frmlittel = new FormLittelEnter();
                            frmlittel.panelProdoct.Visible = false;
                            frmlittel.panelStore.Visible = false;
                            frmlittel.dgSearch.Visible = true;
                            frmlittel.see = 1;
                            frmlittel.ShowDialog();
                            txtCodeProdoct.Text = frmlittel.majhool1;
                            txtNameProdoct.Text = frmlittel.majhool2;
                            txtCodeProdoct.ForeColor = Color.Black;
                            txtNameProdoct.ForeColor = Color.Black;
                            txtNameStore.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("عدد وارد کنید", "ورودی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else
            {
                FormLittelEnter frmlittel = new FormLittelEnter();
                frmlittel.panelProdoct.Visible = true;
                frmlittel.panelStore.Visible = false;
                //frmlittel.dgSearch.BringToFront();
                frmlittel.panelProdoct.Dock = DockStyle.Fill;
                frmlittel.ShowDialog();
            }
            if (txtCodeProdoct.Text == "")
            {
                txtCodeProdoct.ForeColor = Color.DarkGray;
                txtCodeProdoct.Text = "کدکالا";
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
                txtNameProdoct.ForeColor = Color.DarkGray;
                txtNameProdoct.Text = "نام کالا";
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
    }
}


