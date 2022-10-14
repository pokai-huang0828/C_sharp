using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo.Land
{
    public class Lion : Animal
    {
        public Lion(string name) : base("獅子", name, "黃") { }

        public override string Eat()
        {
            return "其他動物的肉肉";
        }

        public override string Move()
        {
            return "四隻腳跑跑跳跳";
        }

        public override string Sound()
        {
            return "吼！吼！吼！";
        }
    }
}
