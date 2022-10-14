using System;
using System.Collections.Generic;
using System.Text;

namespace MyZoo.Land
{
    public class Cat : Animal
    {
        public Cat(string name, string color) : base("貓貓", name, color)
        { }

        public override string Eat()
        {
            return "魚肉、老鼠、偉嘉";
        }
        public override string Sound()
        {
            return "喵！喵！喵！";
        }
        public override string Move()
        {
            return "四隻腳跑跑跳跳！";
        }

        
    }
}