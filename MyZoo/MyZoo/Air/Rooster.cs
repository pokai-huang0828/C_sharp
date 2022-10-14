using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo.Air
{
    public class Rooster : Animal, IBirdAbility
    {
        public Rooster(string name, string color) : base("雞", name, color) { }


        public override string Eat()
        {
            return "小米、小蟲";
        }

        public string Fly()
        {
            return "飛得不高、飛得不快，只能飛一下下";
        }

        public override string Move()
        {
            return "兩隻腳地上慢慢走";
        }

        public override string Sound()
        {
            return "咕！咕！咕！";
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("{0}的飛行：{1}\r\n", this.Name, this.Fly());
            return result;
        }
    }
}
