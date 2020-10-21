using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class SingleLinkedList<T>
    {
        private Node<T> head;// 字段：当前链表的头结点
        private int count; //字段：当前链表节点个数
        public int Count
        {
            get
            {
                return this.count;
            }
        }
        // 索引器
        public T this[int index]
        {
            get
            {
                return this.GetNodeByIndex(index).Item;
            }
            set
            {
                this.GetNodeByIndex(index).Item = value;
            }
        }
        public SingleLinkedList()
        {
            this.count = 0;
            this.head = null;
        }
        private Node<T> GetNodeByIndex(int index)
        {
            if (index < 0 || index >= this.count)
            {
                throw new ArgumentOutOfRangeException("index", "索引超出范围");
            }
            var tmp = this.head;
            for(var i = 0; i < index; i++)
            {
                tmp = tmp.Next;
            }
            return tmp;
        }/// <summary>
        /// 在链表末尾添加节点
        /// </summary>
        public void AddLast(T value)
        {
            var newNode = new Node<T>(value);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                var lastNode = GetNodeByIndex(Count - 1);
                lastNode.Next = newNode;
            }
            this.count++;
        }
        /// <summary>
        /// 指定位置添加节点
        /// </summary>
        public void InsertAt(int index,T value)
        {
            if (index < 0 || index >= this.count)
            {
                throw new ArgumentOutOfRangeException("index", "索引超出范围");
            }
            var newNode = new Node<T>(value);
            if (index == 0)
            {
                if (this.head == null)
                    this.head = newNode;
                else
                {
                    newNode.Next = this.head;
                    this.head = newNode;
                }
            }
            else
            {
                var prevNode = GetNodeByIndex(index - 1);
                newNode.Next = prevNode.Next;
                prevNode.Next = newNode;
            }
            this.count++;
        }
        /// <summary>
        ///  移除指定位置的节点
        /// </summary>
        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                this.head = this.head.Next;
            }
            else
            {
                Node<T> prevNode = GetNodeByIndex(index - 1);
                if (prevNode.Next == null)
                {
                    throw new ArgumentOutOfRangeException("index", "索引超出范围");
                }

                Node<T> deleteNode = prevNode.Next;
                prevNode.Next = deleteNode.Next;

                deleteNode = null;
            }

            this.count--;
        }
        public void Print()
        {
            var str = "SingleLinkedList-> ";
            var tmp = this.head;
            for (var i = 0; i < this.count; i++)
            {
                str += tmp.Item.ToString()+ ",";
                tmp = tmp.Next;
                
            }
            Console.WriteLine(str+"null");
        }
    }
}
