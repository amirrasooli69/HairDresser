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
    public partial class FormTurn : Form
    {
        public FormTurn()
        {
            InitializeComponent();
        }

        public void Setting_DgShow1(string Date)
        {
            
            dgShow1.Columns.Add("Name", "نام");
            dgShow1.Columns["Name"].Width = 150;
            dgShow1.Columns.Add("Hour", "ساعت");
            dgShow1.Columns.Add("Date", "تاریخ");
            dgShow1.Rows.Add(23);

            int row = 0, h = 0;
            while (row < dgShow1.RowCount -1)
            {
                int m = 00;
                dgShow1.Rows[row].DefaultCellStyle.BackColor = Color.LightGray;
                dgShow1.Rows[row].Cells["Hour"].Value = h + ":" + m;
                dgShow1.Rows[row].Cells["Date"].Value = Date;
                m = 30;
                row++;
                dgShow1.Rows[row].DefaultCellStyle.BackColor = Color.White;

                dgShow1.Rows[row].Cells["Hour"].Value = h + ":" + m;
                dgShow1.Rows[row].Cells["Date"].Value = Date;
                h++;
                row++;              
            }
            
        }
        public void Setting_DgShow2(string Date)
        {

            dgShow2.Columns.Add("Name", "نام");
            dgShow2.Columns["Name"].Width = 150;
            dgShow2.Columns.Add("Hour", "ساعت");
            dgShow2.Columns.Add("Date", "تاریخ");
            dgShow2.Rows.Add(23);

            int row = 0, h = 12;
            while (row < dgShow2.RowCount - 1)
            {
                int m = 00;
                dgShow2.Rows[row].DefaultCellStyle.BackColor = Color.LightGray;
                dgShow2.Rows[row].Cells["Hour"].Value = h + ":" + m;
                dgShow2.Rows[row].Cells["Date"].Value = Date;
                m = 30;
                row++;
                dgShow2.Rows[row].DefaultCellStyle.BackColor = Color.White;

                dgShow2.Rows[row].Cells["Hour"].Value = h + ":" + m;
                dgShow2.Rows[row].Cells["Date"].Value = Date;
                h++;
                row++;
            }

        }
        private void FormTurn_Load(object sender, EventArgs e)
        {
            Setting_DgShow1(Practical.Today_Date());
            Setting_DgShow2(Practical.Today_Date());

            pCalander1.dontClose = false;
         }

        private void button2_Click(object sender, EventArgs e)
        {
            dgShow1.Rows.Clear();
            dgShow2.Rows.Clear();
            textBox1.Text = pCalander1.T_Date;
            Setting_DgShow1(pCalander1.T_Date);
            Setting_DgShow2(pCalander1.T_Date);


        }

        private void pCalander1_Click(object sender, EventArgs e)
        {
            textBox1.Text = pCalander1.GetSelectDate();
        }
    }
}
