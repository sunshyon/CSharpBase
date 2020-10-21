using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Factory
{
    public class FileLogger:ILogger
    {
        public void WriteLog()
        {
            Console.WriteLine("文件日志记录...");
        }
    }
}
