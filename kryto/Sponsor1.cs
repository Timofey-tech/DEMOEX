﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kryto
{
    public partial class Sponsor1 : Form
    {
        public Sponsor1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RunnerReg s = new RunnerReg();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            s.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thanks s = new Thanks();
            s.Show();
            this.Close();
        }
    }
}
