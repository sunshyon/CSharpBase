using DP.AbstractFactory.AbstractFactory;
using DP.AbstractFactory.AbstractProduct;
using DP.AbstractFactory.ConcreteProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP.AbstractFactory.ConcreteFactory
{
    public class SpringSkinFactory : ISkinFactory
    {
        public IButton CreateButton()
        {
            return new SpringButton();
        }

        public IComboBox CreateComboBox()
        {
            return new SpringComboBox();
        }

        public ITextField CreateTextField()
        {
            return new SpringTextField();
        }
    }
}
