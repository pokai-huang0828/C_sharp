using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyZoo.Land
{
    public class Dog : Animal
    {
        public Dog(string name, string color) : base("狗狗", name, color)
        { }

        public override string Eat()
        {
            return "肉肉、骨頭、寶路";
        }
        public override string Sound()
        {
            return "汪！汪！汪！";
        }
        public override string Move()
        {
            return "四隻腳跑跑跳跳！";
        }        
    }
}
