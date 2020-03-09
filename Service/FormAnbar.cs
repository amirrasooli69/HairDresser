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
            FormLitelEnter frmLitelEnter = new FormLitelEnter();            
            frmLitelEnter.panelStore.Visible = false;
            frmLitelEnter.panelProdoct.Visible = true;
            frmLitelEnter.Location = new Point(btnAddProdoct.Location.X,btnAddProdoct.Location.Y+220);
            //frmLitelEnter.panelProdoct.Location = new Point(0, 0);
            frmLitelEnter.ShowDialog();

        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            FormLitelEnter frmLitelEnter = new FormLitelEnter();
            frmLitelEnter.panelStore.Visible = true;
            frmLitelEnter.panelProdoct.Visible = false;
            frmLitelEnter.Location = new Point(btnAddStore.Location.X, btnAddStore.Location.Y + 220);
            //frmLitelEnter.panelProdoct.Location = new Point(0, 0);
            frmLitelEnter.ShowDialog();

            
        }

        private void FormAnbar_Click(object sender, EventArgs e)
        {

        }
    }
}
