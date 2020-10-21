using System;
using System.Collections.Generic;
using System.Text;

namespace DP.SimpleFactory
{
    public class ChartFactory
    {
        public static IChartable GetChart(string type)
        {
            IChartable chart = null;
            if (type.Equals("histogram", StringComparison.OrdinalIgnoreCase))
            {
                chart = new HistogramChart();
                Console.WriteLine("初始化设置柱状图...");
            }
            return chart;
        }
    }
}
