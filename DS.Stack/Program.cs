using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var stack = new ArrayStack<int>();
            stack.Print();
            stack.Push(1);
            stack.Print();
            stack.Push(2);
            stack.Print();
            stack.Push(3);
            stack.Print();
            var res = stack.Pop();
            Console.WriteLine("Pop:"+res);
            stack.Print();
            DecToBinary(25);
            Console.ReadLine();
        }
        /// <summary>
        /// 十进制转二进制
        /// </summary>
        static void DecToBinary(int num)
        {
            var n = num;
            var stack = new ArrayStack<int>();
            var residue = 0;
            while (num != 0)
            {
                residue = num % 2;
                stack.Push(residue);
                num = num / 2;
            }
            stack.Print();
            var result = "Binary:";
            while (stack.Size > 0)
            {
                result += stack.Pop();
            }
            Console.WriteLine("Dec:" + n + "->"+result);
        }
    }
}
