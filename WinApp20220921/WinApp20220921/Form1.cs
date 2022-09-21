using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp20220921
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* 	變數的命名規則
	
	    為甚麼要設定宣告變數: 為了記住記憶體位置	
	
	    1. 首自只能使用文字或底線(文字不分中英文，只要是文字即可!)
	    2. 第二字後，可用文字、數字及底線。
	    3. 不得使用關鍵字。

        */

        private void button1_Click(object sender, EventArgs e)
        {
            /*
	        int aa; 	// 宣告整數
	        aa = 100; 	// 賦值(assign value)
	        */

            int aa = 100;
            aa = aa + 200;
            label1.Text = aa.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aa = textBox1.Text;
            int bb = int.Parse(aa);
            bb = bb + 200;
            label1.Text = bb.ToString();
        }
    }
}
