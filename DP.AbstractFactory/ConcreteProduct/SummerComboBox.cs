using DP.AbstractFactory.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.AbstractFactory.ConcreteProduct
{
    public class SummerComboBox : IComboBox
    {
        public void Display()
        {
            Console.WriteLine("显示蓝色边框下拉框...");
        }
    }
}
