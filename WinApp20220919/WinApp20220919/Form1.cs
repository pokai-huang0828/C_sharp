using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp20220919
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "按鈕一被按了!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 把textBox1.Text 傳給 label1.Text
            label1.Text = textBox1.Text + "您好!!";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //測試按鈕.BackColor = Color.FromArgb(223,221,117);
            button1.BackColor = Color.Pink;
        }

        private void 測試按鈕_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightGray;
        }
    }
}
