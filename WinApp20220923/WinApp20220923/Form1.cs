using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp20220923
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int score = int.Parse(textBox1.Text);
            if (score >= 60)
            {
                label1.Text = "及格囉!";
                label1.ForeColor = Color.Blue;
            }
            else
            {
                label1.Text = "不及格!!";
                label1.ForeColor = Color.Red;
            }
        }
    }
}
