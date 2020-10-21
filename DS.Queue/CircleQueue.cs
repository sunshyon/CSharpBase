using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Queue
{
    /// <summary>
    /// 循环队列
    /// </summary>
    public class CircleQueue<T>
    {
        private T[] array;
        private static int maxSize = 10; //队列大小，实际可用大小为：maxSize-1
        private int front;//头指针
        private int rear;//尾指针，若队列不为空，指向队列尾元素的下一个位置

        /*
         队空条件：front==rear;
         队满条件：(rear+1)%maxSize==front;
         队列长度计算：(rear-front+maxSize)%maxSize
        */

        public CircleQueue()
        {
            array = new T[maxSize];
            front = 0;
            rear = 0;
        }
        /// <summary>
        /// 入队
        /// </summary>
        public void EnQueue(T value)
        {
            //队列满判断
            if ((rear + 1) % maxSize == front)
                return;
            array[rear] = value;
            //rear指针后移一位置，若到最后则转到数组头部
            rear = (rear + 1) % maxSize;
        }
        /// <summary>
        /// 出队
        /// </summary>
        public T DeQueue()
        {
            if (front == rear)//队空
                return default(T);
            var value = array[front];//取出队头
            array[front] = default(T);//队头清空
            //front指针后移一位置，若到最后则转到数组头部
            front = (front + 1) % maxSize;
            return value;
        }
        /// <summary>
        /// 求队列长度
        /// </summary>
        public int QueueLength()
        {
            return (rear + maxSize - front) % maxSize;
        }
        public void Print()
        {
            var str = "CicleQueue-> ";
            //if (rear > front)
            //{
            //    for (var i = front; i < rear; i++)
            //    {
            //        str += array[i];
            //    }
            //}
            //if (rear < front)
            //{

            //}
            for(var i = 0; i < 10; i++)
            {
                str += array[i]+",";
            }
            Console.WriteLine(str + "null");
        }
    }
}
