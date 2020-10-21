using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Factory.v3
{
    /// <summary>
    /// 抽象类
    /// </summary>
    public abstract class LoggerFactory
    {
        // 在工厂类中直接调用日志记录器的业务方法WriteLog()
        public void WriteLog()
        {
            ILogger logger = this.CreateLogger();
            logger.WriteLog();
        }
        //定义抽象方法，让子类必须实现
        public abstract ILogger CreateLogger();
    }
}
