using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo.Air
{
    public class Eagle : Animal, IBirdAbility
    {
        public Eagle(string name, string color) : base("老鷹", name, color) { }

        public override string Eat()
        {
            return "其他動物的肉肉";
        }

        public string Fly()
        {
            return "飛得很高、飛得很快！";
        }

        public override string Move()
        {
            return "兩隻腳地上慢慢走";
        }

        public override string Sound()
        {
            return "啊！啊！啊！";
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += string.Format("{0}的飛行：{1}\r\n", this.Name, this.Fly());
            return result;
        }
    }
}
