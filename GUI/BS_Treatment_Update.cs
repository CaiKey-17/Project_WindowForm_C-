﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_CNPM
{
    public partial class BS_Treatment_Update : Form
    {
        private string ten;
        private string soluong;
        public delegate void BS_Treatment_UpdateEventHandler(string text1,string text2);
        public BS_Treatment_UpdateEventHandler bS_Treatment_UpdateEventHandler;
        public delegate void BS_Treatment_UpdateEvent(string text1, string text2,string text3);
        public BS_Treatment_UpdateEvent bS_Treatment_UpdateEvent;
        private int trangthai;
        public BS_Treatment_Update()
        {
            InitializeComponent();
        }

        public void ChangeLanguage(string language)
        {
            if (language == "Vietnam")
            {
                label1.Text = "Cập Nhật";
                lbName.Text = "Tên";
                lbQuantity.Text = "Số lượng";
                label2.Text = "Ghi chú";
                btnDone.Text = "XONG";
            }
            else
            {
                label1.Text = "Update";
                lbName.Text = "Name";
                lbQuantity.Text = "Quantity";
                label2.Text = "Note";
                btnDone.Text = "DONE";
            }
        }

        public BS_Treatment_Update(string ten,string soluong)
        {
            InitializeComponent();
            this.ten = ten;
            this.soluong = soluong;
            tbName.Text = this.ten;
            tbName.Enabled = false;
            tbQuantity.Text = this.soluong;
            trangthai = 0;
        }
        public void change()
        {
            trangthai = 1;
            label2.Visible = true;
            guna2TextBox1.Visible = true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (BLL.CheckTextBox.KiemTraSo(soluong))
            {
                if (trangthai == 0)
                {
                    if (tbQuantity.Text.Length != 0)
                    {
                        bS_Treatment_UpdateEventHandler(ten, tbQuantity.Text);
                    }
                    this.Hide();
                }
                else
                {
                    if (tbQuantity.Text.Length != 0)
                    {
                        bS_Treatment_UpdateEvent(ten, tbQuantity.Text, guna2TextBox1.Text);
                    }
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng");
            }
        }
    }
}
