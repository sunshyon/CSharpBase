using DP.AbstractFactory.AbstractFactory;
using DP.AbstractFactory.AbstractProduct;
using DP.AbstractFactory.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP.AbstractFactory.ConcreteFactory
{
    public class SummerSkinFactory : ISkinFactory
    {
        public IButton CreateButton()
        {
            return new SummerButton();
        }

        public IComboBox CreateComboBox()
        {
            return new SummerComboBox();
        }

        public ITextField CreateTextField()
        {
            return new SummerTextField();
        }
    }
}
