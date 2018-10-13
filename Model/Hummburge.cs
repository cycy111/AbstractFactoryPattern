using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern.Model
{
    public abstract class Hummburge:AbstractBaseFood,IFood
    {
        public void PrintMessage()
        {
            Console.WriteLine("---" + this.kind + "汉堡," + "/t 单价：" + this.price + "/t数量：" + this.num + "/t 总价：" + GetTotalPrice());

        }
    }
}
