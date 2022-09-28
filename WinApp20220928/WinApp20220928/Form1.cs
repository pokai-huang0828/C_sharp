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

        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 0; i <= 42; i++)
            {
                if (i % 4 == 0)  // 先檢查4的倍數再繼續加下去
                    continue;
                result += i + ". 巨匠電腦\r\n";
            }
            textBox1.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string result = "";
            int i = 0;
            while (true)
            {
                if (++i % 4 == 0) continue;
                result += i + ". 巨匠電腦\r\n";
                if (i == 42) break;
            }
            textBox1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string result = "";
            for (int i = 1; i <= 5; i++)
            {
                result += "外圍第 " + i + " 圈\r\n";
                for (int j = 1; j <= 5; j++)
                {
                    result += "\t裡面第 " + j + " 圈\r\n";
                }
            }
            textBox1.Text = result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string result = "";
            int i = 1;
            int j = 1;
            for (i = 1; i <= 9; i++)
            {
                for (j = 1; j <= 9; j++)
                {
                    result += i + "*" + j + "=" + i * j + "\t";
                    if ( i == 6 && j == 6)
                    {
                        break;
                    }
                }
                if (i == 6 )
                {
                    break;
                }
                result += "\r\n";
            }
            textBox1.Text = result;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string result = "";
            int i = 1;
            int j = 1;
            for (i = 1; i <= 9; i++)
            {
                for (j = 1; j <= 9; j++)
                {
                    result += i + "*" + j + "=" + i * j + "\t";
                }
                result += "\r\n";
            }
            textBox1.Text = result;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string result = "";
            int i = 1;
            int j = 1;
            bool isBreak = false;
            for (i = 1; i <= 9; i++)
            {
                for (j = 1; j <= 9; j++)
                {
                    result += i + "*" + j + "=" + i * j + "\t";
                    if (i == 7 && j == 6)
                    {
                        isBreak = true;
                        break;
                    }
                }
                if (isBreak) break;
                result += "\r\n";
            }
            textBox1.Text = result;
        }
    }
}
