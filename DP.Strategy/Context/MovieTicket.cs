using DP.Strategy.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Strategy.Context
{
    /// <summary>
    /// 环境类：电影票
    /// </summary>
    public class MovieTicket
    {
        private double _price;
        private IDiscount _discount;
        public double Price
        {
            get
            {
                return _discount.Calculate(_price);
            }
            set
            {
                _price = value;
            }
        }
        public IDiscount Discount
        {
            set
            {
                _discount = value;
            }
        }
    }
}
