using DP.Command.Receiver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Command
{
    /// <summary>
    /// 具体命令类：帮助命令
    /// </summary>
    public class HelpCommand : Command
    {
        private HelpHandler helpHandler;
        public HelpCommand()
        {
            helpHandler = new HelpHandler();
        }
        public override void Execute()
        {

            if (helpHandler != null)
            {
                helpHandler.Display();
            }
        }
    }
}
