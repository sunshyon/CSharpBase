using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Command.Invoker
{
    /// <summary>
    /// 请求发送者：功能键
    /// </summary>
    public class FunctionButton
    {
        // 功能键名称
        public string Name { get; set; }
        // 维持一个抽象命令对象的引用
        public Command command;

        public FunctionButton(string name)
        {
            this.Name = name;
        }

        public void SetCommand(Command command)
        {
            this.command = command;
        }

        //发送请求
        public void OnClick()
        {
            Console.WriteLine("点击功能键：");
            if (command != null)
            {
                command.Execute();
            }
        }
    }
}
