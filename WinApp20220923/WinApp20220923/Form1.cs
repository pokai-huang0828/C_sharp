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
        /*  巢狀 IF
           if()
           {
               if()
                   {}
           }
         */
        private void button2_Click(object sender, EventArgs e)
        {
            int inputNum = int.Parse(textBox1.Text);
            if (inputNum < 0)
            {
                label1.Text = "負數";
            }
            else if (inputNum < 10)
            {
                label1.Text = "個位數";
            }
            else if (inputNum < 100)
            {
                label1.Text = "2位數";
            }
            else if (inputNum < 1000)
            {
                label1.Text = "3位數";
            }
            else
            {
                label1.Text = "4位數以上";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int inputNum = int.Parse(textBox1.Text);
            if (inputNum < 60)
            {
                label1.Text = "戊等";
            }
            else if (inputNum < 70)
            {
                label1.Text = "丁等";
            }
            else if (inputNum < 80)
            {
                label1.Text = "丙等";
            }
            else if (inputNum < 90)
            {
                label1.Text = "乙等";
            }
            else
            {
                label1.Text = "甲等";
            }

        }



        /* 選項變數 switch
            
            switch 
            {
                case [選項]: [處理敘述];
                break;
            }

        */

        private void button4_Click(object sender, EventArgs e)
        {
            int choice = int.Parse(textBox2.Text);
            string s = "";
            label1.ForeColor = Color.Black;
            switch (choice)
            {
                case 1: s = "豬排";
                    label1.ForeColor = Color.Red;
                    break;
                case 2: s = "雞排";
                    label1.ForeColor = Color.Green; 
                    break;
                case 3: s = "牛排";
                    label1.ForeColor = Color.Azure; 
                    break;
                case 4:                 // 選四就是選五
                case 5: s = "羊排";
                    label1.ForeColor = Color.Chocolate; 
                    break;                                  
                default: s = "只有1-4，不要亂選!"; break;
            }
            label1.Text = s;
        }
    }
}
