using DP.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP.AbstractFactory.ConcreteProduct
{
    public class SpringComboBox : IComboBox
    {
        public void Display()
        {
            Console.WriteLine("显示绿色边框下拉框...");
        }
    }
}
