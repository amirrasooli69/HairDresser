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
    public partial class FormLitelEnter : Form
    {
        public FormLitelEnter()
        {
            InitializeComponent();

        }

        private void FormLitelEnter_Load(object sender, EventArgs e)
        {
            //FormAnbar frmAnbar = new FormAnbar();
            //this.Location =frmAnbar.btnAddProdoct.Location;
            
            //panelStore.Location = new Point(0, 0);
            //FormAnbar frmAnbar = new FormAnbar();
            //this.Location = frmAnbar.btnAddProdoct.Location;
        }

        private void panelStore_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
