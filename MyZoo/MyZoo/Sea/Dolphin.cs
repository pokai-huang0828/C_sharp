using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo.Sea
{
    public class Dolphin: Animal
    {
        public Dolphin(string name, string color) : base("海豚", name, color)
        { }

        public override string Eat()
        {
            return "小魚、小蝦、蟹";
        }
        public override string Sound()
        {
            return "唧！唧！唧！";
        }
        public override string Move()
        {
            return "水中游得很快！";
        }


    }
}