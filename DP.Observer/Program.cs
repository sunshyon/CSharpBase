using DP.Observer.Observer;
using DP.Observer.Subject;
using System;

namespace DP.Observer
{
    /// <summary>
    /// 观察者模式
    /// https://www.cnblogs.com/edisonchou/p/7242622.html
    /// 用于建立一种对象与对象之间的依赖关系，一个对象发生改变时将自动通知其他对象，其他对象将相应作出反应
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //定义被观察对象
            AllyControlCenter acc = new ConcreteAllyControlCenter("金庸群侠");
            //定义4个观察者对象
            IObserver playerA = new Player() { Name = "杨过" };
            acc.Join(playerA);
            IObserver playerB = new Player() { Name = "令狐冲" };
            acc.Join(playerB);
            IObserver playerC = new Player() { Name = "张无忌" };
            acc.Join(playerC);
            IObserver playerD = new Player() { Name = "段誉" };
            acc.Join(playerD);

            //当某盟友遭受攻击
            playerA.BeAttacked(acc);
        }
    }
}
