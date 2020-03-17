using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Papiloo
{
    public partial class ucButton : UserControl
    {
        public ucButton()
        {
            InitializeComponent();
        }
        public string show = "";
        private void btn_Click(object sender, EventArgs e)
        {
            ucAddProdoctStore addProdoct = new ucAddProdoctStore();
            
            
        }
    }
}
