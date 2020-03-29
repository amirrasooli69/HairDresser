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
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StimulsoftEntities context = new StimulsoftEntities();
            var name = context.AnbarProdoct.Where(c => c.Name == comboBox1.Text).FirstOrDefault();
            var search = context.Anbar.Where(c => c.IdProdoct == name.Code).ToList();
            dataGridView1.DataSource = search;
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            StimulsoftEntities context = new StimulsoftEntities();
            var prodoct = context.AnbarProdoct.ToList();
            comboBox1.DataSource = prodoct;
            comboBox1.DisplayMember = "Name";
        }
    }
}
