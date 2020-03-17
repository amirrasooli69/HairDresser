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
                addStore.Size = new System.Drawing.Size(280, 200);
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
                addProdoct.Size = new System.Drawing.Size(280, 210);
                pop = new Popup(addProdoct);
                pop.Closed += popup_Closed;
                pop.Show(this);
            }
            
        }
       public static string []getdNewDetail ;

        private void popup_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {

            if(show=="prodoct")
            {

            }
            if (show == "store")
            {
                getdNewDetail = ucAddProdoctStore.store;
                if (getdNewDetail[0] !="")
                {
                    Service.StimulsoftEntities context = new Service.StimulsoftEntities();
                    Service.Store newStore = new Service.Store();
                    newStore.Name = getdNewDetail[0];
                    if (getdNewDetail[1] !="")
                        newStore.Phone = getdNewDetail[1];
                    if (getdNewDetail[2] != "")
                        newStore.Address = getdNewDetail[2];
                    context.Store.Add(newStore);
                    context.SaveChanges();
                }
            }
        }
    }
}
