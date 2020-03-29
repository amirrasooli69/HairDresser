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

        private void AnabarReport_Load(object sender, EventArgs e)
        {
            StimulsoftEntities context = new StimulsoftEntities();
            var prodocts = context.AnbarProdoct.ToList();
            comProdoct.DataSource = prodocts;
            comProdoct.DisplayMember = "Name";

        }

        private void btnReportProdoct_Click(object sender, EventArgs e)
        {
            
        }
    }
}
