using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo
{
    public class Animal
    {
        private string name;
        private string color;
        private string type;

        public string Name { get { return this.name; } }
        public string Color { get { return this.color; } }
        public string Type { get { return this.type; } }

        public Animal(string type, string name, string color)
        {
            this.type = type;
            this.name = name;
            this.color = color;
        }

        public string Eat()
        {
            return "食物";
        }
        public string Sound()
        {
            return "反正有聲音！";
        }
        public string Move()
        {
            return "反正會動！";
        }

        public override string ToString()
        {
            string aa = "";
            aa += string.Format("{0}的名字：{1}\r\n", this.type, this.name);
            aa += string.Format("{0}的顏色：{1}\r\n", this.name, this.color);
            aa += string.Format("{0}的吃：{1}\r\n", this.name, this.Eat());
            aa += string.Format("{0}的聲音：{1}\r\n", this.name, this.Sound());
            aa += string.Format("{0}的動作：{1}\r\n", this.name, this.Move());
            return aa;
        }

    }
}
