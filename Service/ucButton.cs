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

            if (show == "prodoct")
            {
                if (ucAddProdoctStore.get.Length>0)
                {
                    getdNewDetail = ucAddProdoctStore.get.Split(',');
                    if(getdNewDetail[0] != "" && getdNewDetail[1] !="")
                    {
                        Service.AnbarProdoct prodoct = new Service.AnbarProdoct();
                        prodoct.Name = getdNewDetail[0];
                        prodoct.Code = int.Parse(getdNewDetail[1]);
                        if (getdNewDetail[2] == "")
                        {
                            prodoct.Id = int.Parse(getdNewDetail[2]);
                        }
                        if (getdNewDetail[3] == "")
                        {
                            prodoct.Description = getdNewDetail[3];
                        }
                        if (getdNewDetail[4] == "")
                        {
                            prodoct.Barcode = getdNewDetail[4];
                        }
                        if (getdNewDetail[5] == "")
                        {
                            prodoct.RfID = getdNewDetail[5];
                        }
                            context.AnbarProdoct.Add(prodoct);                       
                    }
                    context.SaveChanges();
                    Service.FormAnbar anbar = new Service.FormAnbar();
                    anbar.Refresh_dgProdoct();

                }

            }
            if (show == "store")
            {
                if (ucAddProdoctStore.get.Length>0)
                {
                    getdNewDetail = ucAddProdoctStore.get.Split(',');
                    if (getdNewDetail[0] != "")
                    {
                        Service.Store newStore = new Service.Store();
                        newStore.Name = getdNewDetail[0];
                        if (getdNewDetail[1] != "")
                        {
                            newStore.Phone = getdNewDetail[1];
                        }
                        if (getdNewDetail[2] != "")
                        {
                            newStore.Address = getdNewDetail[2];
                        }
                        context.Store.Add(newStore);
                    }
                    context.SaveChanges();
                }
                Service.FormAnbar frmAnbar = new Service.FormAnbar();
                frmAnbar.Refresh_dgStore();
            }
        }
    }
}
