using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var bTree = new BinaryTree<String>("A");
            var root = bTree.Root;

            bTree.InsertLeft(root, "B");
            bTree.InsertRight(root, "C");

            var B = bTree.Root.lchild;
            bTree.InsertLeft(B, "D");
            bTree.InsertRight(B, "E");

            Console.WriteLine("前序遍历：根->左->右");
            bTree.PreOrder(root);
            Console.WriteLine("中序遍历：左->根->右");
            bTree.MidOrder(root);
            Console.WriteLine("后序遍历：左->右->根");
            bTree.PostOrder(root);

            Console.WriteLine("非递归前序遍历：根->左->右");
            bTree.PreOrderNR(root);
            Console.WriteLine("非递归中序遍历：左->根->右");
            bTree.MidOrderNR(root);

            var a=bTree.GetDepth(root);

            //bTree.InsertLeft(root, "Test");

            Console.ReadLine();
        }
    }
}
