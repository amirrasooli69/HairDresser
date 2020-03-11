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
        StimulsoftEntities context = new StimulsoftEntities();

        private void btnNew_Click(object sender, EventArgs e)
        {
            AnbarParent parent = new AnbarParent();
            parent.Case = comCase.SelectedIndex;
            parent.Date = int.Parse(Date.Text.Replace("/",""));
            parent.Description = txtDetails.Text;
            context.AnbarParent.Add(parent);
            context.SaveChanges();
            //------
            dgAnbar.Enabled = true;
            dgAnbar.Focus();
            
            
            
        }

        private void FormAnbar_Load(object sender, EventArgs e)
        {
            Date.Text = Practical.Today_Date();
            comCase.SelectedIndex = 0;
            dgAnbar.Enabled = false;
        }

        private void dgAnbar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                FormLittelEnter frmlittel = new FormLittelEnter();
                frmlittel.panelProdoct.Visible = false;
                frmlittel.panelStore.Visible = false;
                frmlittel.dgSearch.BringToFront();
                frmlittel.dgSearch.Dock = DockStyle.Fill;                
                frmlittel.ShowDialog();
            }
        }
    }
}
