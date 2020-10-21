using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Factory.v3
{
    public class DatabaseLoggerFactory : LoggerFactory
    {
        public override ILogger CreateLogger()
        {
            ILogger logger = new DatabaseLogger();
            return logger;
        }
    }
}
