using System;

namespace DP.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalancer balancer, balancer2, balancer3;
            balancer = LoadBalancer.GetBalancer();
            balancer2 = LoadBalancer.GetBalancer();
            balancer3 = LoadBalancer.GetBalancer();
            // 判断负载均衡器是否相同
            if (balancer == balancer2 && balancer == balancer3 && balancer2 == balancer3)
            {
                var test=balancer.Equals(balancer2);
                Console.WriteLine("^_^ : 服务器负载均衡器是唯一的！");
            }

            // 增加服务器
            balancer.AddServer(new Server() { Name = "Server 1" });
            balancer.AddServer(new Server() { Name = "Server 2" });
            balancer.AddServer(new Server() { Name = "Server 3" });
            balancer.AddServer(new Server() { Name = "Server 4" });

            // 模拟客户端请求的分发
            for (int i = 0; i < 10; i++)
            {
                Server server = balancer.GetServer();
                Console.WriteLine("该请求已分配至 : " + server.Name);
            }
        }
    }
}
