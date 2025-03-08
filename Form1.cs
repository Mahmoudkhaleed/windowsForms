using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormControl
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            while (progressBar1.Value < progressBar1.Maximum)
            {
                Thread.Sleep(500);
                progressBar1.Value += 10;
                label1.Text = ((float)progressBar1.Value / progressBar1.Maximum * 100)+ "%";
                progressBar1.Refresh();
                label1.Refresh();
            }
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            progressBar1.Value = 0;
            label1.Text = "0%";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form fr = new Form2();
            fr.Show();
        }
    }
}
