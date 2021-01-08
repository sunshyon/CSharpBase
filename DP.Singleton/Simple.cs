using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Singleton
{
    /// <summary>
    /// 简单实现单例（饿汉式）
    /// </summary>
    public class Simple
    {
        private static readonly Simple _singleton;

        static Simple()
        {
            _singleton = new Simple();
        }
        public static Simple GetInstance()
        {
            return _singleton;
        }
    }
}
