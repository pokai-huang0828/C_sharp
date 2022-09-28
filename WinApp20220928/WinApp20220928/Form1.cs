using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp20220928
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 0; i <= 42; i++)
            {
                result += i + ". 巨匠電腦\r\n";
                if (i == 20)
                    break;
            }
            textBox1.Text = result;
        }
    }
}
