using System;
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
    public partial class RunnerMenu : Form
    {
        public RunnerMenu()
        {
            InitializeComponent();
        }
        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 s = new Form1();
            s.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunnerReg2 s = new RunnerReg2();
        }
    }
}
