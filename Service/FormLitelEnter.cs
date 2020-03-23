using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class FormLittelEnter : Form
    {
        public FormLittelEnter()
        {
            InitializeComponent();

        }
        StimulsoftEntities context = new StimulsoftEntities();
        public int see = 0; //baraye por kardan dgshow va por kardanesh
        public string majhool1 = "";
        public string majhool2 = "";
        public void Select_Show()
        {
            if (see == 2) // namayeshe sabte mahsool
            {
                panelStore.Visible = false;
                dgSearch.Visible = false;
                panelProdoct.Visible = true;
                panelProdoct.Dock = DockStyle.Fill;
                tooltxtSearch.Visible = false;
                Fill_ComUnit();

            }
            if (see == 3) // namayeshe sabte store
            {
                panelStore.Visible = true;
                dgSearch.Visible = false;
                panelProdoct.Visible = false;
                panelStore.Dock = DockStyle.Fill;
                tooltxtSearch.Visible = false;
            }

            if (see == 1)
            {
                panelProdoct.Visible = false;
                panelStore.Visible = false;
                dgSearch.Visible = true;
                dgSearch.Dock = DockStyle.Fill;
                dgSearch.RightToLeft = RightToLeft.Yes;
                dgSearch.DataSource = context.AnbarProdoct.ToList();
                dgSearch.Columns[0].Visible = false;
                dgSearch.Columns[1].Visible = false;
                dgSearch.Columns[2].HeaderText = "نام محصول";
                dgSearch.Columns[3].HeaderText = "کد کالا";
                dgSearch.Columns[4].HeaderText = "توضیحات";
                dgSearch.Columns[5].HeaderText = "بارکد";
                dgSearch.Columns[6].HeaderText = "تگ شناسایی";
                dgSearch.Columns[7].Visible = false;
                dgSearch.Columns[8].Visible = false;
                //------
                tooltxtSearch.Visible = true;
            }
        }
        private void Add_Prodoct()
        {
            AnbarProdoct newprodoct = new AnbarProdoct();
            newprodoct.Name = txtNameProdoct.Text;
            newprodoct.Code = long.Parse(txtCodeProdoct.Text);
            newprodoct.IdUnit = comUnit.SelectedIndex;
            newprodoct.Description = txtDetails.Text;
            newprodoct.Barcode = txtBarcode.Text;
            newprodoct.RfID = txtRFID.Text;
            context.AnbarProdoct.Add(newprodoct);
            context.SaveChanges();
            MessageBox.Show("محصول ثبت شد", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNameProdoct.Text = "";
            txtCodeProdoct.Text = "";
            txtDetails.Text = "";
            txtBarcode.Text = "";
            txtRFID.Text = "";
            txtNameProdoct.Focus();
        }
        public void Fill_ComUnit()
        {
            comUnit.DataSource = context.Unit.ToList();
            comUnit.DisplayMember = "Name";
        }
        private void FormLitelEnter_Load(object sender, EventArgs e)
        {
            Select_Show();
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveProdoct_Click(object sender, EventArgs e)
        {
            using (var context = new StimulsoftEntities())
            {
                if (context.AnbarProdoct.Count() > 0)
                {
                    bool existProdoct = context.AnbarProdoct.Where(c => c.Name == txtNameProdoct.Text).Any();
                    if (existProdoct)
                    {
                        MessageBox.Show("این نام محصول تکراری است", "ثبت", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {

                        Add_Prodoct();


                    }
                }
                else
                {
                    Add_Prodoct();
                }

            }
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            FormAddUnit frmUnit = new FormAddUnit();
            //frmUnit.Location = new Point(btnAddUnit.Location.X,btnAddUnit.Location.Y);
            frmUnit.ShowDialog();
            Fill_ComUnit();

        }

        private void dgSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormAnbar frmAnbar = new FormAnbar();
            majhool1 = dgSearch.CurrentRow.Cells[3].Value.ToString();
            majhool2= dgSearch.CurrentRow.Cells[2].Value.ToString();
            this.Close();

        }

        private void tooltxtSearch_Enter(object sender, EventArgs e)
        {
            if(tooltxtSearch.Text=="جستجو")
            {
                tooltxtSearch.Text = "";
            }
        }

        private void tooltxtSearch_Leave(object sender, EventArgs e)
        { 
            if(tooltxtSearch.Text=="")
            {
                tooltxtSearch.Text = "جستجو";
            }
        }

        private void tooltxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(context.AnbarProdoct.Count()>0)
                {
                    var searchtProdoct = context.AnbarProdoct.Where(c => c.Name.StartsWith(tooltxtSearch.Text)).ToList();
                    dgSearch.DataSource = searchtProdoct;
                }
            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
