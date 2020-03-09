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
            frmLittelEnter.Location = new Point(btnAddProdoct.Location.X+30,btnAddProdoct.Location.Y+220);
            //frmLitelEnter.panelProdoct.Location = new Point(0, 0);
            frmLittelEnter.ShowDialog();

        }

        private void btnAddStore_Click(object sender, EventArgs e)
        {
            FormLittelEnter frmLittelEnter = new FormLittelEnter();
            frmLittelEnter.panelStore.Visible = true;
            frmLittelEnter.panelProdoct.Visible = false;
            frmLittelEnter.Location = new Point(btnAddStore.Location.X+30, btnAddStore.Location.Y + 220);
            //frmLitelEnter.panelProdoct.Location = new Point(0, 0);
            frmLittelEnter.ShowDialog();

            
        }

        private void FormAnbar_Click(object sender, EventArgs e)
        {

        }
    }
}
