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
    public partial class ucAddProdoctStore : UserControl
    {
        public ucAddProdoctStore()
        {
            InitializeComponent();
        }
        public string show = "";
        private void ucAddProdoctStore_Load(object sender, EventArgs e)
        {
            switch (show)
            {
                case "sore":
                    {
                        panelStore.Visible = true;
                        panelProdoct.Visible = false;
                        panelProdoct.Dock = DockStyle.Fill;
                        break;
                    }
            }
        }
    }
}
