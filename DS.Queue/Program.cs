using System;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var queue = new ArrayQueue<int>();
            //queue.EnQueue(1);
            //queue.Print();
            //queue.EnQueue(2);
            //queue.Print();
            //queue.EnQueue(3);
            //queue.Print();
            //queue.DeQueue();
            //queue.Print();

            //循环队列
            var cQ = new CircleQueue<int>();
            cQ.EnQueue(1);
            cQ.Print();
            cQ.EnQueue(2);
            cQ.Print();
            cQ.EnQueue(3);
            cQ.Print();
            cQ.DeQueue();
            cQ.Print();
            cQ.EnQueue(4);
            cQ.EnQueue(5);
            cQ.EnQueue(6);
            cQ.EnQueue(7);
            cQ.DeQueue();
            cQ.DeQueue();
            cQ.EnQueue(9);
            cQ.EnQueue(10);
            cQ.EnQueue(11);
            cQ.EnQueue(12);
            cQ.Print();
            Console.ReadLine();
        }
    }
}
