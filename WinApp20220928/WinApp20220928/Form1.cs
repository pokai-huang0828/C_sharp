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
                    //result += i + "*" + j + "=" + (i * j).ToString("00") + "  ";
                    result += string.Format("{0}*{1}={2:00}  ", i, j, i * j);
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

        private void button8_Click(object sender, EventArgs e)
        {
            string a = "巨匠電腦";
            int b = 12345678;
            double c = 56.789;
            DateTime d = DateTime.Now;

            string reault = "";

            reault += b.ToString("c") + "\r\n";
            reault += c.ToString("p") + "\r\n";
            reault += c.ToString("#.0%") + "\r\n";
            reault += d.ToLongDateString() + "\r\n";
            reault += d.ToShortDateString() + "\r\n";
            reault += d.ToLongTimeString() + "\r\n";
            reault += d.ToShortTimeString() + "\r\n";
            reault += d.ToString("D") + "\r\n";
            reault += d.ToString("d") + "\r\n";
            reault += d.ToString("yyyy-MM-dd dddd HH:mm:ss") + "\r\n";

            reault += string.Format("A的值: {0}, B的值: {1:C}, C的值: {2:P}, D的值 {3:D}, B的值: {1:#.0}", a, b, c, d);


            textBox1.Text = reault;

            /*
                1. 2-1000 質數
                2. 100-1000 中的 {水仙花} 數 "阿姆斯壯數"
                3.*
                  **
                  ***
                  ****
                  *****
                4.    *
                     **
                    ***
                   ****
                  *****
                5.     *
                      ***
                     *****
                    *******
                   *********
              
            */
        }
    }
}
