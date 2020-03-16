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

namespace PapilooDate
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        Popup popup;
        private void button1_Click(object sender, EventArgs e)
        {
            AddProdoct frm = new AddProdoct();

            popup = new Popup(frm);
            popup.Closed += popup_Closed;
            popup.Show(this);
        }
        private void popup_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            //S_Date.Text = PCalander.Pc_Date;
        }
    }
}
