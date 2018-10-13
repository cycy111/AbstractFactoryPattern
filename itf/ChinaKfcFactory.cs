using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryPattern.Model;
using AbstractFactoryPattern.Model.kfc;
namespace AbstractFactoryPattern.itf
{
    public class ChinaKfcFactory:IKfcFactory
    {
        public ChinaKfcFactory()
        {

        }
         Hummburge IKfcFactory.CreateHummburg(int number)
        {
            return new ChinaHumbug(number);
        }
        KitchenSwing IKfcFactory.CreateKitchenswing(int number)
        {
            return new ChinaKitchenSwing(number);
        }
    }
}
