﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlykho
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangnhap f = new dangnhap();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formThemnhap t = new formThemnhap();
            t.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Xuathang t = new Xuathang();
            t.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
               Thongke t = new Thongke();
               t.ShowDialog();
          }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }
    }
}
