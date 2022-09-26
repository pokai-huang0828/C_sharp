using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp20220926
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "Mom says:\"It's time to wake up!\"\r\nMe:\"Okay!!\"";
            textBox1.Text = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string result = "";
            string a = "巨匠電腦桃園認證中心桃園市政府";

            result = result + "字串長度: " + a.Length + "\r\n";
            result = result + "子字串1: " + a.Substring(10) + "\r\n";
            result = result + "子字串2: " + a.Substring(4, 2) + "\r\n";

            result = result + "從前搜尋位置1: " + a.IndexOf("桃園") + "\r\n";
            result = result + "從前搜尋位置2: " + a.IndexOf("桃園", 5) + "\r\n";

            result = result + "從後搜尋位置1: " + a.LastIndexOf("桃園") + "\r\n";
            result = result + "從後搜尋位置2: " + a.LastIndexOf("桃園", 6) + "\r\n";

            result = result + "取代: " + a.Replace("桃園", "台北") + "\r\n";

            result = result + "插入: " + a.Insert(10, "新竹") + "\r\n";

            // 分割 
            string b = "AA,BB:CC.DD,EE:FF";
            string[] bb = b.Split(',', ':', '.');
            for (int i = 0; i < bb.Length; i++)
                result += bb[i] + "\r\n";

            textBox1.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string result = "";
            int i = 1;

            for ( ; i <=10; i +=2)
            {
                result += "執行第" + i.ToString() + "次，巨匠電腦\r\n";
            }

            result += "執行第" + i.ToString() + "次";

            textBox1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int startNum = 300;
            int sumNum = 0;
            int sumNum偶數 = 0;
            int sumNum奇數 = 0;

            for (; startNum <= 1500; startNum ++)
            {
                sumNum += startNum;
                if (startNum % 2 ==0)
                {
                    sumNum偶數 += startNum;
                }
                else
                {
                    sumNum奇數 += startNum;
                }
            }

            textBox1.Text = "總和: \t" + sumNum.ToString() + "\r\n" +
                            "奇數和: \t" + sumNum奇數.ToString() + "\r\n" +
                            "偶數和: \t" + sumNum偶數.ToString();
        }
    }
}
