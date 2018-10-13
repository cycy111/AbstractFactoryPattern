using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryPattern.itf;
using AbstractFactoryPattern.Model;
using AbstractFactoryPattern.Model.kfc;
namespace AbstractFactoryPattern
{
    public class Customer
    {
        IKfcFactory KfcFactory;
        public Customer(IKfcFactory kfcFactory)
        {
            this.KfcFactory = kfcFactory;
            
        }
        public float OrderHumburg(int num)
        {
            Hummburge hb =  KfcFactory.CreateHummburg(num);
            hb.PrintMessage();
            return hb.GetTotalPrice();
        }
        public float OrderKitchenwing(int num)
        {
            KitchenSwing kw = KfcFactory.CreateKitchenswing(num);
            kw.PrintMessage();
            return kw.GetTotalPrice();
        }
    }
}
