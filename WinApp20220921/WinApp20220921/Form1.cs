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
	            為甚麼要設定宣告變數? ANS:為了記住記憶體位置!!	
	            1. 首自只能使用文字或底線(文字不分中英文，只要是文字即可!)
	            2. 第二字後，可用文字、數字及底線。
	            3. 不得使用關鍵字。
            
            駱駝命名法(變數方法):
               https://zh.m.wikipedia.org/zh-tw/%E9%A7%9D%E5%B3%B0%E5%BC%8F%E5%A4%A7%E5%B0%8F%E5%AF%AB
            巴斯卡命名法(類別物件):
                Visual Studio 使用其命名法! 
                https://www.easyatm.com.tw/wiki/%E5%B8%95%E6%96%AF%E5%8D%A1%E5%91%BD%E5%90%8D%E6%B3%95

        */



        private void button1_Click(object sender, EventArgs e)
        {
            /*
	        int aa; 	// 宣告整數
	        aa = 100; 	// 賦值(assign value)
	        */

            int aa = 100;
            aa += 200;
            label1.Text = aa.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;       //使用者輸入身高
            int userHeight = int.Parse(inputText);
            int stdWeight = userHeight - 110;
            label1.Text = "標準體重: " + stdWeight.ToString() + "公斤";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmV = cmValue.Text;      //使用這輸入身高
            float m = float.Parse(cmV);     //輸入轉換成浮點數
            m = (float)(m / 100);           //身高轉換成公尺

            string kgV = kgValue.Text;      //使用者輸入體重
            float kg = float.Parse(kgV);    //輸入轉換成浮點數

            float BMI = kg / (m * m);       //公式計算BMI值
            Result.Text = BMI.ToString();   //將結果輸出到label
        }
    }
}
