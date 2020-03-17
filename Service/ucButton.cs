using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PopupControl;

namespace Papiloo
{
    public partial class ucButton : UserControl
    {
        public ucButton()
        {
            InitializeComponent();
        }
        public string show = "";
        Popup pop;
        private void btn_Click(object sender, EventArgs e)
        {
            if (show == "store")
            {
                ucAddProdoctStore addStore = new ucAddProdoctStore();
                addStore.panelProdoct.Visible = false;
                addStore.panelStore.Visible = true;
                addStore.panelStore.Dock = DockStyle.Fill;
                pop = new Popup(addStore);
                pop.Closed += popup_Closed;
                pop.Show(this);
            }
            if(show=="prodoct")
            {
                ucAddProdoctStore addProdoct = new ucAddProdoctStore();
                addProdoct.panelProdoct.Visible = true;
                addProdoct.panelStore.Visible = false;
                addProdoct.panelProdoct.Dock = DockStyle.Fill;
                pop = new Popup(addProdoct);
                pop.Closed += popup_Closed;
                pop.Show(this);
            }
            
        }
        private void popup_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            //S_Date.Text = PCalander.Pc_Date;
        }
    }
}
