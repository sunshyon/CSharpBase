using System;
using System.Collections.Generic;
using System.Text;

namespace Tree
{
    public class BinaryTree<T>
    {
        private Node<T> root;
        public Node<T> Root
        {
            get
            {
                return this.root;
            }
        }
        public BinaryTree()
        {
        }
        public BinaryTree(T data)
        {
            this.root = new Node<T>(data);
        }
        #region 基本操作
        /// <summary>
        /// 在节点p下插入左孩子节点，数据为data
        /// </summary>
        public void InsertLeft(Node<T> p, T data)
        {
            Node<T> tempNode = new Node<T>(data);
            tempNode.lchild = p.lchild; //将p原本的左子节点变成新节点的左子节点，

            p.lchild = tempNode;
        }
        /// <summary>
        /// 在节点p下插入右孩子节点，数据为data
        /// </summary>
        public void InsertRight(Node<T> p,T data)
        {
            var tmp = new Node<T>(data);
            tmp.rchild = p.rchild;//将p原本的右子节点变成新节点的右子节点，
            p.rchild = tmp;
        }
        /// <summary>
        /// 删除节点p下的左子树
        /// </summary>
        public Node<T> RemoveLeft(Node<T> p)
        {
            if (p == null || p.lchild == null)
                return default(Node<T>);
            var tmp = p.lchild;
            p.lchild = null;
            return tmp;
        }
        /// <summary>
        /// 删除节点p下的右子树
        /// </summary>
        public Node<T> RemoveRight(Node<T> p)
        {
            if (p == null || p.rchild == null)
                return default(Node<T>);
            var tmp = p.rchild;
            p.rchild = null;
            return tmp;
        }
        /// <summary>
        /// 判断节点p是否叶子节点
        /// </summary>
        public bool IsLeafNode(Node<T> p)
        {
            if (p == null)
                return false;
            return p.lchild == null && p.rchild == null;
        }
        /// <summary>
        /// 计算二叉树的深度 -> 递归的次数
        /// </summary>
        public int GetDepth(Node<T> p)
        {
            if (p == null)
                return 0;
            var lDepth = GetDepth(p.lchild);
            var rDepth = GetDepth(p.rchild);

            if (lDepth > rDepth)
                return lDepth + 1;
            else
                return rDepth + 1;
        }
        #endregion

        #region 递归遍历
        /// <summary>
        /// 前序遍历
        /// </summary>
        public void PreOrder(Node<T> p)
        {
            if (p != null)
            {
                //根->左->右
                Console.WriteLine(p.data);
                PreOrder(p.lchild);
                PreOrder(p.rchild);
            }
        }
        /// <summary>
        /// 中序遍历
        /// </summary>
        public void MidOrder(Node<T> p)
        {
            if (p != null)
            {
                //左->根->右
                MidOrder(p.lchild);
                Console.WriteLine(p.data);
                MidOrder(p.rchild);
            }
        }
        /// <summary>
        /// 后序遍历
        /// </summary>
        public void PostOrder(Node<T> p)
        {
            if (p != null)
            {
                //左->右->根
                PostOrder(p.lchild);
                PostOrder(p.rchild);
                Console.WriteLine(p.data);
            }
        }
        #endregion


        #region 非递归遍历 
        /*
         利用了循环和栈的先进后出的特性
        */
        /// <summary>
        /// 前序遍历(根->左->右)
        /// </summary>
        public void PreOrderNR(Node<T> p)
        {
            if (p == null)
                return;
            Stack<Node<T>> stack = new Stack<Node<T>>();
            stack.Push(p);
            Node<T> tmp = null;

            while (stack.Count > 0)
            {
                //1、遍历根节点
                tmp = stack.Pop();
                Console.WriteLine(tmp.data);
                //2、右子树压栈
                if (tmp.rchild != null)
                    stack.Push(tmp.rchild);
                //3、左子树压栈（目的:保证下一个出栈的是左子树的节点）
                if (tmp.lchild != null)
                    stack.Push(tmp.lchild);
            }
        }
        /// <summary>
        /// 中序遍历(左->根->右)
        /// </summary>
        public void MidOrderNR(Node<T> p)
        {
            if (p == null)
                return;
            Stack<Node<T>> stack = new Stack<Node<T>>();
            Node<T> tmp = p;

            while (tmp != null || stack.Count > 0)
            {
                //1、依次将所有左子树节点压栈
                while (tmp != null)
                {
                    stack.Push(tmp);
                    tmp = tmp.lchild;
                }
                //2、出栈遍历节点
                tmp = stack.Pop();
                Console.WriteLine(tmp.data);
                //3、左子树遍历结束则跳转到右子树
                tmp = tmp.rchild;
            }
        }
        /// <summary>
        /// 后序遍历(左->右->根)
        /// </summary>
        public void PostOrderNR(Node<T> p)
        {
            if (p == null)
                return;
            Stack<Node<T>> stackIn = new Stack<Node<T>>();
            Stack<Node<T>> stackOut = new Stack<Node<T>>();
            Node<T> curr = null;
            stackIn.Push(p); //根节点首先压栈

            while (stackIn.Count > 0)
            {
                curr = stackIn.Pop();
                stackOut.Push(curr);

                //左子树压栈
                if (curr.lchild != null)
                    stackIn.Push(curr.lchild);

                //右子树压栈
                if (curr.rchild != null)
                    stackIn.Push(curr.rchild);
            }
            while (stackOut.Count > 0)
            {
                // 依次遍历各节点
                Node<T> outNode = stackOut.Pop();
                Console.Write(outNode.data);
            }
        }
        /// <summary>
        /// 层次遍历（广度优先遍历）
        /// </summary>
        public void LevelOrder(Node<T> node)
        {
            if (node == null)
                return;

            // 利用队列先进先出的特性存储节点并输出
            Queue<Node<T>> qNode = new Queue<Node<T>>();
            qNode.Enqueue(node);
            Node<T> tmp = null;

            while (qNode.Count > 0)
            {
                tmp = qNode.Dequeue();
                Console.WriteLine(tmp.data);

                if (tmp.lchild != null)
                    qNode.Enqueue(tmp.lchild);

                if (tmp.rchild != null)
                    qNode.Enqueue(tmp.rchild);
            }
        }
        #endregion
    }
}
