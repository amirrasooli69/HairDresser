﻿using System;
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

        public void Setting_DgShow1(string Date)
        {
            dgShow1.Rows.Clear();
            dgShow1.Columns.Clear();
            //-------
            dgShow1.Columns.Add("Name", "نام");
            dgShow1.Columns["Name"].Width = 150;
            dgShow1.Columns.Add("Time", "ساعت");
            dgShow1.Columns.Add("Date", "تاریخ");
            dgShow1.Rows.Add(23);

            int row = 0, h = 0;
            while (row < dgShow1.RowCount - 1)
            {
                int m = 00;
                dgShow1.Rows[row].DefaultCellStyle.BackColor = Color.LightGray;
                dgShow1.Rows[row].Cells["Time"].Value = h + ":" + m;
                dgShow1.Rows[row].Cells["Date"].Value = Date;
                m = 30;
                row++;
                dgShow1.Rows[row].DefaultCellStyle.BackColor = Color.White;

                dgShow1.Rows[row].Cells["Time"].Value = h + ":" + m;
                dgShow1.Rows[row].Cells["Date"].Value = Date;
                h++;
                row++;
            }

        }
        public void Setting_DgShow2(string Date)
        {
            dgShow2.Rows.Clear();
            dgShow2.Columns.Clear();
            //------
            dgShow2.Columns.Add("Name", "نام");
            dgShow2.Columns["Name"].Width = 150;
            dgShow2.Columns.Add("Time", "ساعت");
            dgShow2.Columns.Add("Date", "تاریخ");
            dgShow2.Rows.Add(23);

            int row = 0, h = 12;
            while (row < dgShow2.RowCount - 1)
            {
                int m = 00;
                dgShow2.Rows[row].DefaultCellStyle.BackColor = Color.LightGray;
                dgShow2.Rows[row].Cells["Time"].Value = h + ":" + m;
                dgShow2.Rows[row].Cells["Date"].Value = Date;
                m = 30;
                row++;
                dgShow2.Rows[row].DefaultCellStyle.BackColor = Color.White;

                dgShow2.Rows[row].Cells["Time"].Value = h + ":" + m;
                dgShow2.Rows[row].Cells["Date"].Value = Date;
                h++;
                row++;
            }

        }
        public void DB_Add_Turn_Person()
        {
            try
            {
                TurnEntities context = new TurnEntities();
                Turn turn = new Turn();
                turn.Name = txtNameTurn.Text;
                if (txtDateTurn.Text == "")
                    txtDateTurn.Text = Practical.Today_Date();
                turn.Date = Int32.Parse(txtDateTurn.Text.Replace("/", ""));
                turn.Time = Int32.Parse(comHourTurn.Text + comMinTurn.Text);
                context.Turn.Add(turn);
                context.SaveChanges();
                lbl1.Text = "add db";
            }
            catch (Exception ex)
            {
                MessageBox.Show(" /n مشکل ثبت نوبت" + ex.Message, "نوبت دهی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void DG_Add_Turn_Person()
        {
            string time = comHourTurn.Text + ":" + comMinTurn.Text;

            if (int.Parse(comHourTurn.Text) >= 12)
            {
                int i = 0;
                while (i < 24)
                {
                    if (dgShow2.Rows[i].Cells["Time"].Value.ToString() == time)
                    {
                        dgShow2.Rows[i].Cells["Name"].Value = txtNameTurn.Text;
                        lbl2.Text = "add dg";
                        break;
                    }
                    i++;
                }
            } else if(int.Parse(comHourTurn.Text)>=0 )
            {
                int i = 0;
                while (i < 24)
                {
                    if (dgShow1.Rows[i].Cells["Time"].Value.ToString() == time)
                    {
                        dgShow1.Rows[i].Cells["Name"].Value = txtNameTurn.Text;
                        lbl2.Text = "add dg";
                        break;
                    }
                    i++;
                }
            }
        }
        private void FormTurn_Load(object sender, EventArgs e)
        {
            Setting_DgShow1(Practical.Today_Date());
            Setting_DgShow2(Practical.Today_Date());
            comHourTurn.Text = "11";
            comMinTurn.Text = "0";
            txtDateTurn.Text = Practical.Today_Date();
            pCalander1.dontClose = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtDateTurn.Text = pCalander1.T_Date;
            Setting_DgShow1(pCalander1.T_Date);
            Setting_DgShow2(pCalander1.T_Date);


        }

        private void pCalander1_Click(object sender, EventArgs e)
        {
            txtNameTurn.Text = pCalander1.GetSelectDate();
        }

        private void btnTurnPerson_Click(object sender, EventArgs e)
        {
            DB_Add_Turn_Person();
            DG_Add_Turn_Person();
        }
    }
}
