using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Observer.Subject
{
    /// <summary>
    /// 具体目标类
    /// </summary>
    public class ConcreteAllyControlCenter : AllyControlCenter
    {
        public ConcreteAllyControlCenter(string allyName)
        {
            Console.WriteLine("系统通知：{0} 战队组建成功！", this.AllyName);
            Console.WriteLine("-------------------------------------------------------");
            this.AllyName = allyName;
        }
        public override void NotifyObserver(string name)
        {
            Console.WriteLine("通知：盟友们，{0} 正遭受敌军攻击，速去抢救！", name);

            foreach(var player in playerList)
            {
                if (!player.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                    player.Help();
            }
        }
    }
}
