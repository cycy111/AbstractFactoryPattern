using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryPattern.Model;
namespace AbstractFactoryPattern.Model.kfc
{
    class ChinaKitchenSwing:KitchenSwing
    {
        public ChinaKitchenSwing(int number)
        {
            this.kind = "奥尔良鸡翅";
            this.price = 12;
            this.num = number;
        }
    }
}
