using System;
using System.Collections.Generic;
using System.Text;

namespace A.Fuck
{
    public class LinkList
    {
        public void TestReverse()
        {
            var list = new SingleLinkList<int>();
            for(var i = 0; i < 3; i++)
            {
                list.AddLast(i+1);
            }
            var newl= Reverse(list.Head);
        }
        /// <summary>
        /// 反转整个链表
        /// </summary>
        public Node<int> Reverse(Node<int> head)
        {
            if (head.Next == null) return head;
            var last = Reverse(head.Next);
            head.Next.Next = head; //常规反转步骤1
            head.Next = null; //常规反转步骤2
            return last;
        }
    }

    public class SingleLinkList<T>
    {
        public T Value;
        public Node<T> Head;
        public Node<T> Next;
        public Node<T> Last;

        public void AddLast(T value)
        {
            var newNode = new Node<T>(value);
            if (this.Head == null)
            {
                this.Head = newNode;
                this.Last = newNode;
            }
            else
            {
                Last.Next = newNode;
                this.Last = newNode;
            }
        }
    }
    public class Node<T> 
    {
        public T Value;
        public Node<T> Next;
        public Node(T value)
        {
            Value = value;
        }
    }

}
