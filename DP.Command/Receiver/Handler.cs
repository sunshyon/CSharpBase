using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Command.Receiver
{
    /// <summary>
    /// 请求接受者：帮助文档处理类
    /// </summary>
    public class WindowHandler
    {
        public void Minimize()
        {
            Console.WriteLine("正在最小化窗口至托盘...");
        }
    }

    /// <summary>
    /// 请求接受者：帮助文档处理类
    /// </summary>
    public class HelpHandler
    {
        public void Display()
        {
            Console.WriteLine("正在显示帮助文档...");
        }
    }
}
