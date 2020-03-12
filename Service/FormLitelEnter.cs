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
        private void FormLitelEnter_Load(object sender, EventArgs e)
        {
            comUnit.DataSource = context.Unit.ToList();
            comUnit.DisplayMember = "Name";
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
    }
}
