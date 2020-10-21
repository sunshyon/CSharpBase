using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class ArrayStack<T>
    {
        private T[] array;
        private int index;
        public ArrayStack()
        {
            this.array = new T[1024] ;
            this.index = 0;
        }
        public int Size
        {
            get
            {
                return index;
            }
        }
        /// <summary>
        /// 入栈
        /// </summary>
        public void Push(T value)
        {
            if (this.index == array.Length)
            {
                // 增大数组容量
                ResizeCapacity(array.Length * 2);
            }
            this.array[index] = value;
            this.index++; //指针指向下一个即将入栈的位置
        }
        /// <summary>
        /// 出栈
        /// </summary>
        public T Pop()
        {
            if (index == 0)
            {
                return default(T);
            }
            var value = this.array[this.index - 1]; //由于index指向下一个入栈位置，所以栈顶序号是index-1
            this.array[this.index-1] = default(T); //栈顶清空
            this.index--;
            if (index > 0 && index == array.Length / 4)
            {
                // 缩小数组容量
                ResizeCapacity(array.Length / 2);
            }
            return value;
        }
        public void Print()
        {
            var str = "ArrayStack-> ";
            for (var i = 0; i < this.index; i++)
            {
                str+=this.array[i].ToString()+",";

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
                for(var i=0;i< array.Length; i++)
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
