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

        public void Setting_DgShow()
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
                dgShow1.Rows[row].Cells["Date"].Value = Practical.Today_Date();
                m = 30;
                row++;
                dgShow1.Rows[row].DefaultCellStyle.BackColor = Color.White;

                dgShow1.Rows[row].Cells["Hour"].Value = h + ":" + m;
                dgShow1.Rows[row].Cells["Date"].Value = Practical.Today_Date();
                h++;
                row++;              
            }
            
        }
        private void FormTurn_Load(object sender, EventArgs e)
        {
            Setting_DgShow();
        }
    }
}
