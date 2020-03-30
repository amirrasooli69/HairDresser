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
        public void Refresh_dgSearch()
        {
            if (count > 1)
            {

                dgSearch.Columns[0].HeaderText = "نام";
                dgSearch.Columns[1].HeaderText = " کد محصول";
                dgSearch.Columns[2].HeaderText = "شماره سند";
                dgSearch.Columns[3].HeaderText = "ورودی";
                dgSearch.Columns[4].HeaderText = "خروجی";
                //dgSearch.Columns[4].Visible = false;
                dgSearch.Columns[5].HeaderText = "قیمت";
                dgSearch.Columns[6].HeaderText = "توضیحات";
                dgSearch.Columns[7].HeaderText = "تاریخ تولید";
                dgSearch.Columns[7].Visible = false;
                dgSearch.Columns[8].HeaderText = "تاریخ انقضا";
                dgSearch.Columns[8].DefaultCellStyle.Format = "0000/00/00";
                dgSearch.Columns[9].HeaderText = "کد رهگیری";
                dgSearch.Columns[10].HeaderText = "شماره مغازه یا فرد";
                dgSearch.Columns[11].HeaderText = "شماره";
                //dgSearch.Columns[12].Visible = false;
                //dgSearch.Columns[13].Visible = false;
                //dgSearch.Columns[14].Visible = false;
                //-------
                //DataGridViewTextBoxColumn positivcColumn = new DataGridViewTextBoxColumn();
                //positivcColumn.HeaderText = "ورودی";
                //positivcColumn.DisplayIndex = 5;
                //this.dgSearch.Columns.Add(positivcColumn);


            }
        }
        public string Calculate_DataGrideView()
        {
            if (count < 1)
                return "0";
            long existing = 0;
            StimulsoftEntities context = new StimulsoftEntities();

            if(dgSearch.RowCount>0)
            {
                for (int i = 0; i < dgSearch.RowCount; i++)
                {
                    long selectCase = Int32.Parse(dgSearch.Rows[i].Cells[2].Value.ToString());
                    var findParentCase = context.AnbarParent.Where(c => c.Id == selectCase).FirstOrDefault();
                    if (findParentCase != null)
                    {
                        switch (findParentCase.Case)
                        {
                            case 0: // reside khard (mojoodi ezafe shavad)
                            case 3: // resid tolid (mojoodi ezafe shavad)
                            case 4: // bargasgt kala foroosh (mojoodi ezafe shavad)
                            case 7: // bargasht kala amani (mojoodi ezafe shavad)
                                {
                                    existing = existing + Int32.Parse(dgSearch.Rows[i].Cells[3].Value.ToString());
                                    break;
                                }


                            case 1: // havale foroosh (mojoodi kam shavad)
                            case 2: // havale masraf (mojoodi kam shavad)
                            case 5: // bargashte kala masraf (mojoodi kam shavad)
                            case 6: // havale anbar amani (mojoodi kam shavad)
                                {
                                    existing = existing - Int32.Parse(dgSearch.Rows[i].Cells[4].Value.ToString());
                                    break;
                                }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return existing.ToString();
        }
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
            Refresh_dgSearch();
            lblTotalExisting.Text=Calculate_DataGrideView();
        }

        private void comProdoct_SelectedIndexChanged(object sender, EventArgs e)
        {
            count++;
            Select_Prodoct();
            Refresh_dgSearch();
            lblTotalExisting.Text=Calculate_DataGrideView();
        }
    }
}
