using DP.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP.AbstractFactory.ConcreteProduct
{
    public class SpringButton : IButton
    {
        public void Display()
        {
            Console.WriteLine("显示浅绿色按钮...");
        }
    }
}
