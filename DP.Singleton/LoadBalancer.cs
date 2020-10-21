using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DP.Singleton
{
    /// <summary>
    /// 单例模式，模拟负载均衡器
    /// 嵌套类 + 静态构造函数
    /// 博文：https://www.cnblogs.com/edisonchou/p/6618503.html
    /// </summary>
    public class LoadBalancer
    {
        private IList<Server> serverList = null;
        public LoadBalancer()
        {
            serverList = new List<Server>();
        }
        /// <summary>
        ///  公共静态成员方法，返回唯一实例
        /// </summary>
        public static LoadBalancer GetBalancer()
        {
            return Nested.instance;
        }
        /// <summary>
        /// 嵌套类
        /// </summary>
        class Nested
        {
            /// <summary>
            /// 静态构造函数 ，.NET运行时（CLR）能够确保只调用一次
            /// </summary>
            static Nested() { }
            internal static readonly LoadBalancer instance = new LoadBalancer();
        }

        public void AddServer(Server server)
        {
            serverList.Add(server);
        }
        public void RemoveServer(string serverName)
        {
            foreach (var server in serverList)
            {
                if (server.Name.Equals(serverName))
                {
                    serverList.Remove(server);
                    break;
                }
            }
        }
        private Random rand = new Random();
        public Server GetServer()
        {
            //随机获得一台Server
            int index = rand.Next(serverList.Count);
            return serverList[index];
        }
    }
}
