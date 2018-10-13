using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryPattern.Model;
namespace AbstractFactoryPattern.itf
{
    public interface IKfcFactory
    {
        KitchenSwing CreateKitchenswing(int number);
        Hummburge CreateHummburg(int number);
    }
}
