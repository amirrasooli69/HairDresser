﻿using System;
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
    public partial class ucAddProdoctStore : UserControl
    {
        public ucAddProdoctStore()
        {
            InitializeComponent();
        }
        public string show = "";
        public static string get;
        Popup pop;
        public void Refresh_comUnit() // update kardane combo box unit
        {
            Service.StimulsoftEntities context = new Service.StimulsoftEntities();
            if (context.Unit.Count() > 0)
            {
                comUnit.DataSource = context.Unit.ToList();
                comUnit.DisplayMember = "Name";
            }
        } 
        private void Add_Prodoct()
        {
            if (txtNameProdoct.TextLength > 0)
            {
                if (txtNameProdoct.Text != "" && txtCodeProdoct.Text != "")
                {
                    Service.StimulsoftEntities context = new Service.StimulsoftEntities();
                    Service.AnbarProdoct prodoct = new Service.AnbarProdoct();
                    prodoct.Name = txtNameProdoct.Text;
                    prodoct.Code = int.Parse(txtCodeProdoct.Text);
                    if (comUnit.SelectedIndex.ToString() == "")
                    {
                        prodoct.Id = comUnit.SelectedIndex;
                    }
                    if (txtDetails.Text == "")
                    {
                        prodoct.Description = txtDetails.Text;
                    }
                    if (txtBarcode.Text == "")
                    {
                        prodoct.Barcode = txtBarcode.Text;
                    }
                    if (txtRFID.Text == "")
                    {
                        prodoct.RfID = txtRFID.Text;
                    }
                    context.AnbarProdoct.Add(prodoct);
                    context.SaveChanges();
                }
                Service.FormAnbar anbar = new Service.FormAnbar();
                anbar.Refresh_dgProdoct();

            }
        } // ezafe kardane mahsoole jadid be jadval prodoct(mahsoolat)
        private void Add_Store() // ezafe kardane forooshgahe jadid be jadvale foroshgah(store)
        {
            Service.StimulsoftEntities context = new Service.StimulsoftEntities();

                    if (txtStoreName.Text != "")
                    {
                        Service.Store newStore = new Service.Store();
                        newStore.Name = txtStoreName.Text;
                        if (txtPhoneStore.Text != "")
                        {
                            newStore.Phone = txtPhoneStore.Text;
                        }
                        if (txtAddressStore.Text != "")
                        {
                            newStore.Address = txtAddressStore.Text;
                        }
                        context.Store.Add(newStore);
                    }
                    context.SaveChanges();
                
                Service.FormAnbar frmAnbar = new Service.FormAnbar();
                frmAnbar.Refresh_dgStore();
            }
        
        private void ucAddProdoctStore_Load(object sender, EventArgs e)
        {
            Refresh_comUnit();
        }

        private void btnSaveStore_Click(object sender, EventArgs e)
        {        
            Add_Store(); 
        }


        private void btnSaveStore_KeyDown(object sender, KeyEventArgs e)
        {
            Add_Store();
        }

        private void btnSaveProdoct_Click(object sender, EventArgs e)
        {
            Add_Prodoct();
        }


        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            ucAddUnit addUnit = new ucAddUnit();
            pop = new Popup(addUnit);
            pop.Closed += popup_Closed;
            pop.Show(this);
        }
        private void popup_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
        }

        private void btnSaveProdoct_KeyPress(object sender, KeyPressEventArgs e)
        {
            Add_Prodoct();
        }
    }
}
