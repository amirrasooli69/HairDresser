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
    public partial class FormAnbar : Form
    {
        public FormAnbar()
        {
            InitializeComponent();
        }

        private void btnAddProdoct_Click(object sender, EventArgs e)
        {
            FormLittelEnter frmLittelEnter = new FormLittelEnter();            
            frmLittelEnter.panelStore.Visible = false;
            frmLittelEnter.panelProdoct.Visible = true;
            //frmLitelEnter.panelProdoct.Location = new Point(0, 0);
            frmLittelEnter.ShowDialog();

        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            FormLittelEnter frmLittelEnter = new FormLittelEnter();
            frmLittelEnter.panelStore.Visible = true;
            frmLittelEnter.panelProdoct.Visible = false;
            //frmLitelEnter.panelProdoct.Location = new Point(0, 0);
            frmLittelEnter.ShowDialog();

            
        }

        private void FormAnbar_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            StimulsoftEntities context = new StimulsoftEntities();
            
        }

        private void FormAnbar_Load(object sender, EventArgs e)
        {
            comCase.SelectedIndex = 0;
            Date.Text = Practical.Today_Date();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            StimulsoftEntities context = new StimulsoftEntities();
            AnbarParent anbarParent = new AnbarParent();
            anbarParent.Case = comCase.SelectedIndex;
            anbarParent.Date =int.Parse(Date.Text.Replace("/", ""));
            anbarParent.Description = txtDetails.Text;
            context.AnbarParent.Add(anbarParent);
            context.SaveChanges();
            //----
            dgAnbar.Enabled = true;
            
        }
    }
}
