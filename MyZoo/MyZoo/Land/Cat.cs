using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo.Land
{
    public class Cat : Animal
    {
        public Cat(string name, string color) : base("貓貓", name, color)
        { }

        public string Eat()
        {
            return "魚肉、老鼠、偉嘉";
        }
        public string Sound()
        {
            return "喵！喵！喵！";
        }
        public string Move()
        {
            return "四隻腳跑跑跳跳！";
        }
    }
}