using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo.Ocean
{
    public class Shark : Animal
    {
        public Shark(string name, string color) : base("鯊魚", name, color)
        { }

        public override string Eat()
        {
            return "魚肉、人肉";
        }
        public override string Sound()
        {
            return "咕嚕！咕嚕！咕嚕！";
        }
        public override string Move()
        {
            return "沒有腳游啊游！";
        }
    }
}
