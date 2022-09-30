using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp20220930
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* ----------------一維 Array 陣列---------------------- */

        private void button1_Click(object sender, EventArgs e)
        {
            //int[] xx;           // 宣告
            //xx = new int[5];    // 實體化

            int[] xx = new int[5];

            xx[0] = 90;
            xx[1] = 80;
            xx[2] = 70;
            xx[3] = 60;
            xx[4] = 50;

            string result = "";
            /*
            result += xx[0] + "\r\n";
            result += xx[1] + "\r\n";
            result += xx[2] + "\r\n";
            result += xx[3] + "\r\n";
            result += xx[4] + "\r\n";
            */
            for (int i = 0; i < 5; i++)
            {
                result += xx[i] + "\r\n";
            }

            textBox1.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int[] xx = new int[] { 90, 80, 70, 60, 50 };
            int[] xx = { 90, 80, 70, 60, 50, 40, 30, 20, 10 };

            string result = "";
            int total = 0;

            foreach (int aa in xx)
            {
                total += aa;
                result += aa + "\r\n";
            }

            result += "總和: " + total;
            textBox1.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[,] xx = new int[4, 5];

            xx[0, 0] = 90;
            xx[0, 2] = 80;
            xx[0, 3] = 70;
            xx[1, 0] = 60;
            xx[1, 1] = 50;
            xx[1, 3] = 40;
            xx[2, 1] = 30;
            xx[2, 2] = 20;
            xx[2, 3] = 10;

            string result = "";

            result += xx.Length + "\r\n";
            result += "第 0 維度: " + xx.GetLength(0) + "\r\n";
            result += "第 1 維度: " + xx.GetLength(1) + "\r\n";

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                    result += xx[i, j] + "\t";
                result += "\r\n";
            }

            textBox1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] xx = { 90, 50, 80, 40, 20, 70, 30, 60, 10 };

            for (int i = 0; i < xx.Length -1; i++)
            {
                for (int j = i; j < xx.Length; j++)
                {
                    if (xx[j] > xx[i])
                    {
                        int temp = xx[i];
                        xx[i] = xx[j];
                        xx[j] = temp;
                    }    
                }
            }

            string result = "";
            foreach (int aa in xx)
            {
                result += aa + "\r\n";
            }

            
            textBox1.Text = result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rr = new Random();

            //rr.NextDouble();  // 0 <= ~ < 1
            //rr.Next(100);     // 0 ~ 99

            string result = "";

            for(int i = 1; i <= 50; i++)
            {
                result += rr.Next(10, 100) + "\r\n";  // rr.Next(minNum, maxNum);
            }

            textBox1.Text = result;
        }

        /*  回家作業
        1. 三大基礎排序法   插入 / 選擇 / 泡沫(氣泡)排序法
        2. 大樂透開獎程式
          2-1. 重抽法
          2-2. 真實世界中的抽獎(抽過是不會放回母體)
        */
    }
}
