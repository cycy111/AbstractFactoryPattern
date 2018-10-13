using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryPattern.Model;
namespace AbstractFactoryPattern.Model.kfc
{
    class ChinaHumbug:Hummburge
    {
        public ChinaHumbug(int number)
        {
            this.kind = "美味汉堡";
            this.price = 15f;
            this.num = number;
        }
    }
}
