using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using MyZoo.Land;
using MyZoo.Ocean;
using MyZoo.Air;

namespace WA20221014
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

            //MyZoo.Animal aa = new MyZoo.Animal("動物", "動動", "色色");
            //result += aa.ToString() + "\r\n";

            MyZoo.Land.Dog d1 = new MyZoo.Land.Dog("小黃", "黃");
            result += d1.ToString() + "\r\n";

            Dog d2 = new Dog("小哈", "灰");
            result += d2.ToString() + "\r\n";

            Cat c1 = new Cat("小咪", "白");
            result += c1.ToString() + "\r\n";

            Lion l1 = new Lion("辛巴");
            result += l1.ToString() + "\r\n";

            Shark s1 = new Shark("小鯊", "灰");
            result += s1.ToString() + "\r\n";

            Dophin do1 = new Dophin("小豚", "灰");
            result += do1.ToString() + "\r\n";

            Eagle e1 = new Eagle("小鷹", "褐白");
            result += e1.ToString() + "\r\n";

            Rooster r1 = new Rooster("小紅", "橘紅");
            result += r1.ToString() + "\r\n";

            Rooster r2 = new Rooster("小烏", "黑");
            result += r2.ToString() + "\r\n";

            Bat b1 = new Bat("小蝠");
            result += b1.ToString() + "\r\n";

            textBox1.Text = result;

        }
    }
}
