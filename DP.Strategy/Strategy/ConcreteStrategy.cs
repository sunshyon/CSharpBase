using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Strategy.Strategy
{
    /// <summary>
    /// 具体策略类：学生票折扣StudentDiscount
    /// </summary>
    public class StudentDiscount : IDiscount
    {
        public double Calculate(double price)
        {
            Console.WriteLine("学生票：");
            return price * 0.8;
        }
    }
    /// <summary>
    /// 具体策略类：VIP会员票VIPDiscount
    /// </summary>
    public class VIPDiscount : IDiscount
    {
        public double Calculate(double price)
        {
            Console.WriteLine("VIP票：");
            Console.WriteLine("增加积分！");
            return price * 0.90;
        }
    }
    /// <summary>
    /// 具体策略类：儿童票折扣ChildrenDiscount
    /// </summary>
    public class ChildrenDiscount : IDiscount
    {
        public double Calculate(double price)
        {
            Console.WriteLine("儿童票：");
            return price / 2;
        }
    }
}
