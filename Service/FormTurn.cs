using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Service
{
    public partial class FormTurn : Form
    {
        public FormTurn()
        {
            InitializeComponent();
        }

        private void FormTurn_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            //Add column header
            listView1.Columns.Add("Time", 100);
            //listView1.Columns["Price"].Text = "gheomat";
            listView1.Columns.Add("Price", 70);
            listView1.Columns.Add("Quantity", 70);

            //Add items in the listview
            string[] arr = new string[4];
            ListViewItem itm;

            //Add first item
            arr[0] = "product_1";
            arr[1] = "100";
            arr[2] = "10";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);

            //Add second item
            arr[0] = "product_2";
            arr[1] = "200";
            arr[2] = "20";
            itm = new ListViewItem(arr);
            listView1.Items.Add(itm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string productName = null;
            string price = null;
            string quantity = null;

            productName = listView1.SelectedItems[0].SubItems[0].Text;
            price = listView1.SelectedItems[0].SubItems[1].Text;
            quantity = listView1.SelectedItems[0].SubItems[2].Text;

            MessageBox.Show(productName + " , " + price + " , " + quantity);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StimulsoftEntities context = new StimulsoftEntities();
            ListViewItem item;
            var category = context.ServicesPrice.ToList();
            string[] a = new string[3];
            for (int i= 0 ;i < category.Count; i++)
            {
                a[0] = category[i].ServiseName;
                a[1] = category[i].ServiceKala;
                a[2] = category[i].ServisKind;
                //a[3] = category[i].ServicePrice.ToString();
                item = new ListViewItem(a);
                listView1.Items.Add(item);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show(click.ToString());
            listView1.Items.RemoveAt(click);
            var list2 = listView1;

           }
        int click;
        private void listView1_Click(object sender, EventArgs e)
        {
           click = listView1.SelectedItems[0].Index;

        }
    }
}
