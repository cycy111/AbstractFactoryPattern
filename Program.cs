using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractFactoryPattern.itf;
using AbstractFactoryPattern.Model;
namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IKfcFactory kfc = new ChinaKfcFactory();
            Customer customer = new Customer(kfc);
            float hbTotal= customer.OrderHumburg(2);
            float swTotal= customer.OrderKitchenwing(4);
            Console.WriteLine("总价：{0}", hbTotal + swTotal);
            
            Console.ReadKey();
        }
    }
}
