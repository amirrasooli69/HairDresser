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
        public static string get;
        
        private void ucAddProdoctStore_Load(object sender, EventArgs e)
        {
            Service.StimulsoftEntities context = new Service.StimulsoftEntities();
            if(context.Unit.Count()>0)
            {
                comUnit.DataSource = context.Unit.ToList();
                comUnit.DisplayMember = "Name";
            }
        }

        private void btnSaveStore_Click(object sender, EventArgs e)
        {
            get = txtStoreName.Text + "," + txtPhoneStore.Text + "," + txtAddressStore.Text;
            //store[0] = txtStoreName.Text;
            //store[1] = txtPhoneStore.Text;
            //store[2] = txtAddressStore.Text;            
        }


        private void btnSaveStore_KeyDown(object sender, KeyEventArgs e)
        {
            get = txtStoreName.Text + "," + txtPhoneStore.Text + "," + txtAddressStore.Text;
        }

        private void btnSaveProdoct_Click(object sender, EventArgs e)
        {
            get = txtNameProdoct.Text + "," + txtCodeProdoct.Text + "," + comUnit.SelectedIndex.ToString() + "," +
                txtDetails.Text + "," + txtBarcode.Text + "," + txtRFID.Text;
        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            
        }
    }
}
