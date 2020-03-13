using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PapilooDate;

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
            parent.Date = int.Parse(Date.Text.Replace("/", ""));
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
                    if (dgAnbar.CurrentCell.Value.ToString() == "" || dgAnbar.CurrentCell.Value == null)
                    {
                        FormLittelEnter frmlittel = new FormLittelEnter();
                        frmlittel.panelProdoct.Visible = false;
                        frmlittel.panelStore.Visible = false;
                        frmlittel.dgSearch.Dock = DockStyle.Fill;
                        frmlittel.dgSearch.DataSource = context.AnbarProdoct.ToList();
                        frmlittel.ShowDialog();
                    }
                    else
                    {
                        if (char.IsDigit(dgAnbar.CurrentRow.Cells[0].Value.ToString(), 0))
                        {
                            Int32 x = int.Parse(dgAnbar.CurrentRow.Cells[0].Value.ToString());
                            var search = context.AnbarProdoct.Where(c => c.code == x).FirstOrDefault();
                            if (search != null)
                            {
                                dgAnbar.CurrentRow.Cells[1].Value = search.Name;
                                dgAnbar.CurrentRow.Cells[2].ReadOnly = true;
                            }
                            if (search == null)
                            {
                                FormLittelEnter frmlittel = new FormLittelEnter();
                                frmlittel.panelProdoct.Visible = true;
                                frmlittel.panelStore.Visible = false;
                                frmlittel.dgSearch.Visible = false;
                                //frmlittel.dgSearch.BringToFront();
                                frmlittel.panelProdoct.Dock = DockStyle.Fill;
                                frmlittel.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("عدد وارد کنید", "ورودی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
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

        private void newProdoct1_Load(object sender, EventArgs e)
        {
            
        }
    }
}


