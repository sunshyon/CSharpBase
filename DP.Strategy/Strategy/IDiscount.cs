using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Strategy.Strategy
{
    /// <summary>
    ///  抽象策略类：折扣Discount
    /// </summary>
    public interface IDiscount
    {
        double Calculate(double price);
    }
}
