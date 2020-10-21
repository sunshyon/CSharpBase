using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Factory
{
    public class FileLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            ILogger logger = new FileLogger();
            return logger;
        }
    }
}
