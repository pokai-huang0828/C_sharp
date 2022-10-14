using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo.Land
{
    public class Bat : Animal, Air.IBirdAbility
    {
        public Bat(string name) : base("蝙蝠", name, "咖啡") { }

        public override string Eat()
        {
            return "昆蟲";
        }

        public string Fly()
        {
            return "利用薄膜翼飛行";
        }

        public override string Move()
        {
            return "在地上慢慢爬行";
        }

        public override string Sound()
        {
            return "超聲波，無聲音";
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("{0}的飛行：{1}\r\n", this.Name, this.Fly());
            return result;
        }
    }
}
