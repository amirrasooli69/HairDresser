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
    public partial class FormAnabarReport : Form
    {
        public FormAnabarReport()
        {
            InitializeComponent();
        }
        int count=0; // baraye dafate avaz shodane comProdoct
        public void Select_Prodoct() // entekhab mahsool 
        {
            if (count > 1)
            {
                StimulsoftEntities context = new StimulsoftEntities();
                var getId = context.AnbarProdoct.Where(c => c.Name == comProdoct.Text).FirstOrDefault();
                var getProdocts = context.Anbar.Where(c => c.IdProdoct == getId.Code).ToList();
                dgSearch.DataSource = getProdocts;
            }
        }
        private void AnabarReport_Load(object sender, EventArgs e)
        {
            StimulsoftEntities context = new StimulsoftEntities();
            if (context.AnbarProdoct.Count() > 0)
            {
                var prodocts = context.AnbarProdoct.ToList();
                comProdoct.DataSource = prodocts;
                comProdoct.DisplayMember = "Name";
            }
        }

        private void btnReportProdoct_Click(object sender, EventArgs e)
        {
            count++;
            Select_Prodoct();

        }

        private void comProdoct_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
            Select_Prodoct();
        }
    }
}
