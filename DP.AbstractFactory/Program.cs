using DP.AbstractFactory.AbstractFactory;
using DP.AbstractFactory.AbstractProduct;
using System;
using Utility;

namespace DP.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ISkinFactory skinFactory = (ISkinFactory)AppConfigHelper.GetFactoryInstance("SummerSkinFactory");
            if (skinFactory == null)
            {
                Console.WriteLine("读取当前选中皮肤类型失败...");
            }
            IButton button = skinFactory.CreateButton();
            ITextField textField = skinFactory.CreateTextField();
            IComboBox comboBox = skinFactory.CreateComboBox();

            button.Display();
            textField.Display();
            comboBox.Display();

            Console.ReadKey();
        }
    }
}
