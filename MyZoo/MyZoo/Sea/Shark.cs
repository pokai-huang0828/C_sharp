using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo.Sea
{
    public class Shark : Animal
    {
        public Shark(string name, string color) : base("鯊魚", name, color)
        { }

        public override string Eat()
        {
            return "海豹、海獅、海龜";
        }
        public override string Sound()
        {
            return "沒有聲音！";
        }
        public override string Move()
        {
            return "水中游得很快！";
        }


    }
}