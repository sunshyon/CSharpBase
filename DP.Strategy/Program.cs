using DP.Strategy.Context;
using DP.Strategy.Strategy;
using System;

namespace DP.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var mt = new MovieTicket();
            double oPrice = 60.0;

            mt.Price = oPrice;
            Console.WriteLine("原始票价：{0}", oPrice);
            Console.WriteLine("----------------------------------------");

            IDiscount discount1 = new StudentDiscount();
            if (discount1 != null)
            {
                mt.Discount = discount1;
                var currPrice = mt.Price;
                Console.WriteLine("学生折后票价：{0}", currPrice);
            }
            IDiscount discount2 = new VIPDiscount();
            if (discount2 != null)
            {
                mt.Discount = discount2;
                var currPrice = mt.Price;
                Console.WriteLine("VIP折后票价：{0}", currPrice);
            }
            IDiscount discount3 = new ChildrenDiscount();
            if (discount3 != null)
            {
                mt.Discount = discount3;
                var currPrice = mt.Price;
                Console.WriteLine("儿童折后票价：{0}", currPrice);
            }
        }
    }
}
