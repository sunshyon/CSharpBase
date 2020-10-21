using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Factory
{
    public class DatabaseLoggerFactory : ILoggerFactory
    {
        public ILogger CreateLogger()
        {
            var logger = new DatabaseLogger();
            return logger;
        }
    }
}
