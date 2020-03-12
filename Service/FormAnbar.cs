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

        private void dgAnbar_Enter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgAnbar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {

            }
        }

        private void dgAnbar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (context.AnbarProdoct.Count() > 0)
                {
                    //long x=long.Parse( dgAnbar.CurrentCell.Value.ToString());
                    var search = context.AnbarProdoct.Where(c => c.code == long.Parse(dgAnbar.CurrentCell.Value.ToString())).FirstOrDefault();
                    if(search !=null)
                    {
                        dgAnbar.CurrentRow.Cells[1].Value = search.Name;
                        dgAnbar.CurrentRow.Cells[2].ReadOnly = true;
                    }

                }
                else
                {
                    FormLittelEnter frmlittel = new FormLittelEnter();
                    frmlittel.panelProdoct.Visible = true;
                    frmlittel.panelStore.Visible = false;
                    //frmlittel.dgSearch.BringToFront();
                    frmlittel.panelProdoct.Dock = DockStyle.Fill;
                    frmlittel.ShowDialog();
                }

            }
        }
    }
}
