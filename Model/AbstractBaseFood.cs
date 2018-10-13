using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern.Model
{
    public class AbstractBaseFood 
    {
        protected string kind;
        protected int num;
        protected float price;
        public float GetTotalPrice()
        {
            return this.num * this.price;
        }
    }
}
