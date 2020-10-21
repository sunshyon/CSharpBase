using DP.Factory.v3;
using System;
using Utility;
namespace DP.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            #region v1
            //普通方式
            ILoggerFactory factoryV1 = new FileLoggerFactory();
            if (factoryV1 == null) return;
            ILogger loggerV1 = factoryV1.CreateLogger();
            loggerV1.WriteLog();
            #endregion

            #region v2
            //引入配置文件
            ILoggerFactory factoryV2 = (ILoggerFactory)AppConfigHelper.GetFactoryInstance("LoggerFactory");
            if (factoryV2 == null) return;
            ILogger loggerV2 = factoryV2.CreateLogger();
            loggerV2.WriteLog();
            #endregion

            #region v3
            //使用抽象类,对客户端隐藏工厂方法,在工厂类中直接调用产品类的业务方法
            LoggerFactory factoryV3 = (LoggerFactory)AppConfigHelper.GetFactoryInstance("LoggerFactory");
            if (factoryV2 == null) return;
            factoryV3.WriteLog();
            #endregion
        }
    }
}
