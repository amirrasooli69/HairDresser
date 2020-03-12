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
        public void Fill_ComUnit()
        {
            comUnit.DataSource = context.Unit.ToList();
            comUnit.DisplayMember = "Name";
        }
        private void FormLitelEnter_Load(object sender, EventArgs e)
        {
            Fill_ComUnit();
        }

        private void panelStore_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveProdoct_Click(object sender, EventArgs e)
        {
            using(var context=new StimulsoftEntities())
            {
                bool exist = false;
                var allProdoct = context.AnbarProdoct.ToList();
                for(int i=0;i<allProdoct.Count;i++)
                {
                    if(allProdoct[i].Name==txtNameProdoct.Text)
                    {
                        MessageBox.Show("این نام محصول تکراری است");
                        exist = true;
                        break;
                    }
                }
                if(exist==false)
                {
                    AnbarProdoct prodoct = new AnbarProdoct();
                    prodoct.Name = txtNameProdoct.Text;
                   
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
    }
}
