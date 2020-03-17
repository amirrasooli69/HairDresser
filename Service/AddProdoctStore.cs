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
        public static string[] store;
        private void ucAddProdoctStore_Load(object sender, EventArgs e)
        {
        }

        private void btnSaveStore_Click(object sender, EventArgs e)
        {
            store[0] = txtStoreName.Text;
            store[1] = txtPhoneStore.Text;
            store[2] = txtAddressStore.Text;            
        }
    }
}
