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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void dg_Click(object sender, EventArgs e)
        {

        }
        string a = "";

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (dg.CurrentCell.Value.ToString()!="")
                textBox1.Text = dg.CurrentCell.Value.ToString();
        }

        private void test_Load(object sender, EventArgs e)
        {

        }

        private void dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                timer1.Interval = 2000;
                timer1.Start();
            }
        }

        private void test_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
