using System;
using System.Collections.Generic;
using System.Text;

namespace Queue
{
    public class ArrayQueue<T>
    {
        private T[] array;
        private int size;
        private int front;
        private int rear;
        public ArrayQueue()
        {
            this.array = new T[1024];
            this.size = 0;
            this.front = this.rear = 0;
        }
        /// <summary>
        /// 入队
        /// </summary>
        public void EnQueue(T value)
        {
            if (size == array.Length)
            {
                // 扩大数组容量
                ResizeCapacity(array.Length * 2);
            }
            array[rear] = value;
            rear++;

            size++;
        }
        /// <summary>
        /// 出队
        /// </summary>
        public T DeQueue()
        {
            if (size == 0)
            {
                return default(T);
            }
            T value = array[front];//取出队头
            array[front] = default(T);//清理队头
            front++; //队头指针向后移动
            if (front > 0 && Size == array.Length / 4)
            {
                // 缩小数组容量
                ResizeCapacity(array.Length / 2);
            }
            size--;
            return value;
        }
        /// <summary>
        /// 栈中节点个数
        /// </summary>
        public int Size
        {
            get
            {
                return this.size;
            }
        }
        public void Print()
        {
            var str = "ArrayQueue-> ";
            for (var i = front; i < this.rear; i++)
            {
                str += this.array[i].ToString() + ",";

            }
            Console.WriteLine(str + "null");
        }
        /// <summary>
        /// 重置数组大小
        /// </summary>
        private void ResizeCapacity(int newCapacity)
        {
            var newArray = new T[newCapacity];
            if (newCapacity > array.Length)
            {
                for (var i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
            }
            else
            {
                for (var i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = array[i];
                }
            }
            this.array = newArray;
        }
    }
}
