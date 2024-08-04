﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CNPM
{
    public partial class Rec_Calendar : Form
    {
        DateTime date;
        DateTime now = DateTime.Now;
        private int thang;
        private int nam;
        public Rec_Calendar()
        {
            InitializeComponent();
        }

        private static bool isVietnam = true;

        public void ChangeLanguage(string language)
        {
            if(language == "Vietnam") 
            {
                isVietnam = true;
                label4.Text = "Chọn Bác sĩ";
            }
            else
            {
                isVietnam = false;
                label4.Text = "Choose Doctor";
            }
        }

        public void ChangeColor(Color color, Color color2)
        {
            panel1.BackColor = panel3.BackColor = color;
            if (color2 == Color.FromArgb(50,50,50))
            {
                guna2Button1.FillColor  = color2;
                flowLayoutPanel1.BackColor = color2;
                label4.ForeColor = Color.White;
                this.BackColor = color2;
            }
            else
            {
                guna2Button1.FillColor = Color.White;
                label4.ForeColor = Color.Black;
                this.BackColor = Color.FromArgb(255, 238, 238);
                flowLayoutPanel1.BackColor = Color.FromArgb(255, 238, 238);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Owner_Staff owner_Staff = new Owner_Staff();
            if (isVietnam)
            {
                owner_Staff.ChangeLanguage("Vietnam");
            }
            else
            {
                owner_Staff.ChangeLanguage("English");
            }
            owner_Staff.truyenBacSi = new Owner_Staff.TruyenBacSi(LoadBacSi);
            owner_Staff.change();
            owner_Staff.ShowDialog();
        }
        private void LoadBacSi(string text)
        {
            guna2Button1.Text = text;
            thang = DateTime.Now.Month;
            nam = DateTime.Now.Year;
            tbMonth.Text = thang.ToString();
            tbYear.Text = nam.ToString();
            show();
        }

        private void show()
        {
            flowLayoutPanel1.Controls.Clear();

            DateTime starMonth = new DateTime(nam, thang, 1);
            //lấy số ngày trong tháng
            int daysofmonth = DateTime.DaysInMonth(nam, thang);

            int daysofweek = Convert.ToInt32(starMonth.DayOfWeek.ToString("d"));
            for (int i = 0; i < 7; i++)
            {
                Date d = new Date(i + 2);
                flowLayoutPanel1.Controls.Add(d);
            }

            if (daysofweek == 0)
            {
                daysofweek = 7;
            }
            List<string> strings = BLL.Doctor.GetLichLam(guna2Button1.Text, thang, nam);
            for (int i = 1; i < daysofweek; i++)
            {
                Empty empty = new Empty();
                flowLayoutPanel1.Controls.Add(empty);
            }
            for (int i = 0; i < daysofmonth; i++)
            {
                Blank blank = new Blank(i + 1, thang, nam, guna2Button1.Text);
                if (strings.Contains((i + 1).ToString()))
                    blank.change();
                flowLayoutPanel1.Controls.Add(blank);
            }
        }

        private void Rec_Calendar_Load(object sender, EventArgs e)
        {
            thang = DateTime.Now.Month;
            nam = DateTime.Now.Year;
            tbMonth.Text = thang.ToString();
            tbYear.Text = nam.ToString();
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            if(guna2Button1.Text.Length == 0)
            {
                if (isVietnam)
                {
                    MessageBox.Show("Vui lòng chọn bác sĩ");
                }
                else
                {
                    MessageBox.Show("Please select a doctor.");
                }
            }
            else
            {
                show();

            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            if (thang == 1)
            {
                thang = 12;
                nam--;
            }
            else
            {
                thang--;
            }
            tbMonth.Text = thang.ToString();
            tbYear.Text = nam.ToString();
            if (guna2Button1.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ");
            }
            else
            {
                show();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (thang == 12)
            {
                thang = 1;
                nam++;
            }
            else
            {
                thang++;
            }
            tbMonth.Text = thang.ToString();
            tbYear.Text = nam.ToString();
            if (guna2Button1.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ");
            }
            else
            {
                show();
            }
        }
    }
}
