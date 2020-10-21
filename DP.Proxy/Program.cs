using DP.Proxy.Proxy;
using DP.Proxy.Subject;
using System;

namespace DP.Proxy
{
    /// <summary>
    /// 代理模式
    /// https://www.cnblogs.com/edisonchou/p/7163867.html
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ISearcher searcher = new ProxySearcher();
            if (searcher != null)
            {
                string result = searcher.DoSearch("杨过", "玉女心经");
            }
        }
    }
}
