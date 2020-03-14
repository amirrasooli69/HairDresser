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

namespace Service
{
    public partial class FormAnbar : Form
    {
        public FormAnbar()
        {
            InitializeComponent();
        }
        StimulsoftEntities context = new StimulsoftEntities();

        private void btnNew_Click(object sender, EventArgs e)
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



        }

        private void FormAnbar_Load(object sender, EventArgs e)
        {
            Date.Text = Practical.Today_Date();
            comCase.SelectedIndex = 0;
            dgAnbar.Enabled = false;
            groupProdoct.Enabled = false;
            dateExpird.Text = Practical.Today_Date();
        }

        private void dgAnbar_Enter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgAnbar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgAnbar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (context.AnbarProdoct.Count() > 0)
                {
                    if (dgAnbar.CurrentCell.Value.ToString() == "" || dgAnbar.CurrentCell.Value == null)
                    {
                        FormLittelEnter frmlittel = new FormLittelEnter();
                        frmlittel.panelProdoct.Visible = false;
                        frmlittel.panelStore.Visible = false;
                        frmlittel.dgSearch.Dock = DockStyle.Fill;
                        frmlittel.dgSearch.DataSource = context.AnbarProdoct.ToList();
                        frmlittel.ShowDialog();
                    }
                    else
                    {
                        if (char.IsDigit(dgAnbar.CurrentRow.Cells[0].Value.ToString(), 0))
                        {
                            Int32 x = int.Parse(dgAnbar.CurrentRow.Cells[0].Value.ToString());
                            var search = context.AnbarProdoct.Where(c => c.code == x).FirstOrDefault();
                            if (search != null)
                            {
                                dgAnbar.CurrentRow.Cells[1].Value = search.Name;
                                dgAnbar.CurrentRow.Cells[2].ReadOnly = true;
                            }
                            if (search == null)
                            {
                                FormLittelEnter frmlittel = new FormLittelEnter();
                                frmlittel.panelProdoct.Visible = true;
                                frmlittel.panelStore.Visible = false;
                                frmlittel.dgSearch.Visible = false;
                                //frmlittel.dgSearch.BringToFront();
                                frmlittel.panelProdoct.Dock = DockStyle.Fill;
                                frmlittel.ShowDialog();
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

            }
        }
        public string[] prodoct()
        {
            string[] prodoct1 = {txtCodeProdoct.Text , txtNameProdoct.Text , txtStoreProdoct.Text ,
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
            txtCodeProdoct.Text = "";
        }

        private void txtCodeProdoct_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodeProdoct_Leave(object sender, EventArgs e)
        {
            if(txtCodeProdoct.Text=="")
            {
                txtCodeProdoct.Text = "کدکالا";
            }
        }

        private void txtNameProdoct_Enter(object sender, EventArgs e)
        {
            txtNameProdoct.Text = "";
        }

        private void txtNameProdoct_Leave(object sender, EventArgs e)
        {
            if(txtNameProdoct.Text=="")
            {
                txtNameProdoct.Text = "نام کالا";
            }
        }

        private void txtStoreProdoct_Leave(object sender, EventArgs e)
        {
            if(txtStoreProdoct.Text=="")
            {
                txtStoreProdoct.Text = "نام فروشگاه یا فرد";
            }
        }

        private void txtStoreProdoct_Enter(object sender, EventArgs e)
        {
            txtStoreProdoct.Text = "";
        }

        private void txtSomeProdoct_Enter(object sender, EventArgs e)
        {
            txtSomeProdoct.Text = "";
        }

        private void txtSomeProdoct_Leave(object sender, EventArgs e)
        {
            if(txtSomeProdoct.Text=="")
            {
                txtSomeProdoct.Text = "مقدار";
            }
        }

        private void txtPriceProdoct_Leave(object sender, EventArgs e)
        {
            if(txtPriceProdoct.Text=="")
            {
                txtPriceProdoct.Text = "قیمت";
            }
        }

        private void txtPriceProdoct_Enter(object sender, EventArgs e)
        {
            txtPriceProdoct.Text = "";
        }

        private void txtDetailProdoct_Enter(object sender, EventArgs e)
        {
            txtPriceProdoct.Text = "";
        }

        private void txtDetailProdoct_Leave(object sender, EventArgs e)
        {
            if(txtPriceProdoct.Text=="")
            {
                txtPriceProdoct.Text = "توضیحات";
            }
        }
    }
}


