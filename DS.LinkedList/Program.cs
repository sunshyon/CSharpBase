using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("测试单链表");
            var sll = new SingleLinkedList<int>();
            sll.Print();
            sll.AddLast(1);
            sll.Print();
            sll.AddLast(2);
            sll.Print();
            sll.AddLast(3);
            sll.Print();
            sll.InsertAt(1, 666);
            sll.Print();
            sll.RemoveAt(2);
            sll.Print();
            Console.ReadLine();
        }
    }
}
