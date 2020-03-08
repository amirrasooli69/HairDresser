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
        FormLitelEnter frmLitelEnter = new FormLitelEnter();

        private void btnAddProdoct_Click(object sender, EventArgs e)
        {
            FormLitelEnter frmLitelEnter = new FormLitelEnter();
            
            frmLitelEnter.panelStore.Visible = false;
            frmLitelEnter.panelProdoct.Visible = true;
          
            frmLitelEnter.ShowDialog();

        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            frmLitelEnter.panelProdoct.Visible = false;
            frmLitelEnter.panelStore.Visible = true;
            //frmLitelEnter.panelStore.BringToFront();
            frmLitelEnter.panelStore.Location = btnAddProdoct.Location;
            //frmLitelEnter.Show();
            frmLitelEnter.ShowDialog();

            
        }

        private void FormAnbar_Click(object sender, EventArgs e)
        {
            //frmLitelEnter.Close();
            //frmLitelEnter.Dispose();
        }
    }
}
