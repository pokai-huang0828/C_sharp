using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo.Ocean
{
    public class Dophin : Animal
    {
        public Dophin(string name, string color) : base("海豚", name, color)
        { }

        public override string Eat()
        {
            return "魚肉";
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
