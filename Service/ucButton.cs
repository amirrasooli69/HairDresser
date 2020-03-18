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
        Service.StimulsoftEntities context = new Service.StimulsoftEntities();
        public static string[] getdNewDetail;

        private void btn_Click(object sender, EventArgs e)
        {
            switch (show)
            {
                case "store":
                    {
                        ucAddProdoctStore addStore = new ucAddProdoctStore();
                        addStore.panelProdoct.Visible = false;
                        addStore.panelStore.Visible = true;
                        addStore.panelStore.Dock = DockStyle.Fill;
                        addStore.Size = new System.Drawing.Size(280, 200);
                        pop = new Popup(addStore);
                        pop.Closed += popup_Closed;
                        pop.Show(this);
                        break;
                    }
                case "prodoct":
                    {
                        ucAddProdoctStore addProdoct = new ucAddProdoctStore();
                        addProdoct.panelProdoct.Visible = true;
                        addProdoct.panelStore.Visible = false;
                        addProdoct.panelProdoct.Dock = DockStyle.Fill;
                        addProdoct.Size = new System.Drawing.Size(280, 210);
                        pop = new Popup(addProdoct);
                        pop.Closed += popup_Closed;
                        pop.Show(this);
                        break;
                    }
            }

        }

        private void popup_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {

        }
    }
}
