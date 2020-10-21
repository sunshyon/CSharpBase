using System;
using System.Collections.Generic;
using System.Text;
using DP.Command.Invoker;

namespace DP.Command
{
    public class FBSettingWindow
    {
        //窗口标题
        public string Title { get; set; }
        // 所有功能键集合
        private IList<FunctionButton> fbList = new List<FunctionButton>();
        public FBSettingWindow(string title)
        {
            Title = title;
        }
        public void AddFunctionButton(FunctionButton fb)
        {
            fbList.Add(fb);
        }
        public void RemoveFunctionButton(FunctionButton fb)
        {
            fbList.Remove(fb);
        }

        // 显示窗口及功能键
        public void Display()
        {
            Console.WriteLine("显示窗口：{0}", this.Title);
            Console.WriteLine("显示功能键：");

            foreach (var fb in fbList)
            {
                Console.WriteLine(fb.Name);
            }
            Console.WriteLine("------------------------------------------");
        }
    }
}
