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
            dgShow1.RowTemplate.Height = 25;
            dgShow1.Columns.Add("Name", "نام");
            dgShow1.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgShow1.Columns["Name"].Width = 150;
            dgShow1.Columns.Add("Time", "ساعت");
            dgShow1.Columns["Time"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgShow1.Columns.Add("Date", "تاریخ");
            dgShow1.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgShow1.Rows.Add(23);

            int row = 0, h = 0;

            while (row < dgShow1.RowCount - 1)
            {
                string m = "00";
                dgShow1.Rows[row].DefaultCellStyle.BackColor = Color.LightGray;
                dgShow1.Rows[row].Cells["Time"].Value = h + ":" + m;
                dgShow1.Rows[row].Cells["Date"].Value = Date;
                m = "30";
                row++;
                dgShow1.Rows[row].DefaultCellStyle.BackColor = Color.White;

                dgShow1.Rows[row].Cells["Time"].Value = h + ":" + m;
                dgShow1.Rows[row].Cells["Date"].Value = Date;
                h++;
                row++;
            }

        } // tarahi dgshow1
        public void Setting_DgShow2(string Date)
        {
            dgShow2.Rows.Clear();
            dgShow2.Columns.Clear();
            dgShow2.RowTemplate.Height = 25;

            //------

            dgShow2.Columns.Add("Name", "نام");
            dgShow2.Columns["Name"].Width = 150;
            dgShow2.Columns["Name"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgShow2.Columns.Add("Time", "ساعت");
            dgShow2.Columns["Time"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgShow2.Columns.Add("Date", "تاریخ");
            dgShow2.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgShow2.Rows.Add(23);

            int row = 0, h = 12;
            while (row < dgShow2.RowCount - 1)
            {
                string m = "00";
                dgShow2.Rows[row].DefaultCellStyle.BackColor = Color.LightGray;
                dgShow2.Rows[row].Cells["Time"].Value = h + ":" + m;
                dgShow2.Rows[row].Cells["Date"].Value = Date;
                m = "30";
                row++;
                dgShow2.Rows[row].DefaultCellStyle.BackColor = Color.White;

                dgShow2.Rows[row].Cells["Time"].Value = h + ":" + m;
                dgShow2.Rows[row].Cells["Date"].Value = Date;
                h++;
                row++;
            }

        } // tarahi dgshow2
        public void DB_Add_Turn_Person() // ezafe kardane nobat fard to DataBase
        {
            TurnEntities context = new TurnEntities();
            try
            {
                Turn turn = new Turn();
                turn.Name = txtNameTurn.Text;
                if (txtDateTurn.Text == "")
                    txtDateTurn.Text = Practical.Today_Date();
                turn.Date = Int32.Parse(txtDateTurn.Text.Replace("/", ""));
                turn.Time = Int32.Parse(comHourTurn.Text + comMinTurn.Text);
                turn.State = comState.SelectedIndex; //0 active - 1 reserv - 2 cancel
                context.Turn.Add(turn);
                //context.SaveChanges();
                lbl1.Text = "add person";
            }
            catch (Exception ex)
            {
                MessageBox.Show(" /n مشکل ثبت نوبت" + ex.Message, "نوبت دهی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //------DB_ADD_WorkColleague
            try
            {
                WorkColleague workColleague = new WorkColleague();
                workColleague.Name = comColleague.Text;
                if (txtDateTurn.Text == "")
                    txtDateTurn.Text = Practical.Today_Date();
                workColleague.Date = Int32.Parse(txtDateTurn.Text.Replace("/", ""));
                workColleague.Time = Int32.Parse(comHourTurn.Text + comMinTurn.Text);
                workColleague.IdColleague = comColleague.SelectedIndex;
                workColleague.IdTurn = comState.SelectedIndex;
                context.WorkColleague.Add(workColleague);
                context.SaveChanges();
                lbl2.Text = "add coll";
            }
            catch (Exception ex)
            {
                MessageBox.Show(" /n مشکل ثبت نوبت" + ex.Message, "نوبت دهی", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void DG_Add_Turn_Person(string Name, string Time)
        {
            string[] h = Time.Split(':');

            if (int.Parse(h[0]) >= 12)
            {
                int i = 0;
                while (i < 24)
                {
                    if (dgShow2.Rows[i].Cells["Time"].Value.ToString() == Time)
                    {
                        dgShow2.Rows[i].Cells["Name"].Value = Name;
                        lbl2.Text = "add dg";
                        break;
                    }
                    i++;
                }
            }
            else if (int.Parse(h[0]) >= 0)
            {
                int i = 0;
                while (i < 24)
                {
                    if (dgShow1.Rows[i].Cells["Time"].Value.ToString() == Time)
                    {
                        dgShow1.Rows[i].Cells["Name"].Value = Name;
                        lbl2.Text = "add dg";
                        break;
                    }
                    i++;
                }
            }
        } // ezafe kardane nobate afrad to dgahow1 va dgshow2

        public void DG_Fill(string Date , int State) // por kardane dgshow1 va dgshow2 be soorate koli 
        {
            dgShow1.ClearSelection();
            dgShow2.ClearSelection();
            TurnEntities context = new TurnEntities();
            int date = int.Parse(Date.Replace("/", ""));
            var selectDate = context.Turn.Where(c => c.Date == date && c.State==State).ToList();
            for (int i = 0; i < selectDate.Count(); i++)
            {
                string time = selectDate[i].Time.ToString();
                if (time == "0")
                    time = "000";
                if (time == "30")
                    time = "030";
                time = time.Insert(time.Length - 2, ":");
                DG_Add_Turn_Person(selectDate[i].Name, time);
            }
        }

        private void FormTurn_Load(object sender, EventArgs e)
        {
            Setting_DgShow1(Practical.Today_Date());
            Setting_DgShow2(Practical.Today_Date());
            dgShow1.ClearSelection();
            dgShow2.ClearSelection();
            comHourTurn.Text = "1";
            comMinTurn.Text = "00";
            txtDateTurn.Text = Practical.Today_Date();
            pCalander1.dontClose = false;
            //------
            {
                StimulsoftEntities context = new StimulsoftEntities();
                comColleague.DataSource = context.Colleague.ToList();
                comColleague.DisplayMember = "Name";
            }
            comState.SelectedIndex = 0;
            DG_Fill(Practical.Today_Date(),comState.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtDateTurn.Text = pCalander1.T_Date;
            Setting_DgShow1(pCalander1.T_Date);
            Setting_DgShow2(pCalander1.T_Date);
            DG_Fill(txtDateTurn.Text,comState.SelectedIndex);


        }

        private void pCalander1_Click(object sender, EventArgs e)
        {
            txtNameTurn.Text = pCalander1.GetSelectDate();
        }

        private void btnTurnPerson_Click(object sender, EventArgs e)
        {
            DB_Add_Turn_Person();
            DG_Add_Turn_Person(txtNameTurn.Text, comHourTurn.Text + ":" + comMinTurn.Text);
        }

        private void dgShow1_Enter(object sender, EventArgs e)
        {
            dgShow2.ClearSelection();
        }

        private void dgShow2_Enter(object sender, EventArgs e)
        {
            dgShow1.ClearSelection();
        }

        private void dgShow1_Click(object sender, EventArgs e)
        {
            string time = dgShow1.CurrentRow.Cells["Time"].Value.ToString();
            string[] t = time.Split(':');
            comMinTurn.Text = t[1];
            comHourTurn.Text = t[0];
        }

        private void dgShow2_Click(object sender, EventArgs e)
        {
            string time = dgShow2.CurrentRow.Cells["Time"].Value.ToString();
            string[] t = time.Split(':');
            comMinTurn.Text = t[1];
            comHourTurn.Text = t[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TurnEntities context = new TurnEntities();
            Turn turn = new Turn();
            WorkColleague workcolleague = new WorkColleague();
            string y = "1399";
            string month = "01";
            string day = "01";
            for (int m = 1; m < 13; m++) //mah
            {
                month = m.ToString();
                if (month.Length == 1)
                    month = "0" + month;
                for (int d = 1; d < 32; d++) //rooz
                {
                    day = d.ToString();
                    if (day.Length == 1)
                        day = "0" + day;

                    string date = y + month + day;

                    
                    for (int a = 0; a < 24; a++) //sat
                    {


                        string hour = a.ToString();
                        string minuts = "00";
                        string time = hour + minuts;
                        //-----------------
                        turn.Time = int.Parse(time);
                        workcolleague.Time = int.Parse(time);
                        //------------------
                        turn.Date = int.Parse(date);
                        workcolleague.Date = int.Parse(date);
                        //------------------
                        turn.Name = "محمد جواد باقری شیجانی";
                        workcolleague.Name = "محمد انصاری پور سنگسری";
                        //-----------------
                        workcolleague.IdColleague = 1233;

                        context.Turn.Add(turn);
                        context.WorkColleague.Add(workcolleague);
                        context.SaveChanges();
                        //----
                        minuts = "30";
                        time = hour + minuts;
                        //-----------------
                        turn.Time = int.Parse(time);
                        workcolleague.Time = int.Parse(time);
                        //------------------
                        turn.Date = int.Parse(date);
                        workcolleague.Date = int.Parse(date);
                        //------------------
                        turn.Name = "محمد جواد باقری شیجانی";
                        workcolleague.Name = "محمد انصاری پور سنگسری";
                        //-----------------
                        workcolleague.IdColleague = 1233;

                        context.Turn.Add(turn);
                        context.WorkColleague.Add(workcolleague);
                        //----

                        context.Turn.Add(turn);
                        context.WorkColleague.Add(workcolleague);
                        context.SaveChanges();
                        progressBar1.Value++;
                    }



                    
                    //----------

                }

                //MessageBox.Show(m);

            }
            MessageBox.Show("do it");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DG_Fill(txtDateTurn.Text, comState.SelectedIndex);
        }
    }
}
