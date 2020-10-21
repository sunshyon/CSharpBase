using DP.Iterator.Aggregate;
using DP.Iterator.Iterator;
using System;
using System.Collections.Generic;

namespace DP.Iterator
{
    /// <summary>
    /// 迭代器（Iterator）模式
    /// 提供一种方法来访问聚合对象，而不用暴露这个对象的内部表示，其别名为游标（Cursor）
    /// https://www.cnblogs.com/edisonchou/p/7442138.html
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IList<object> products = new List<object>();
            products.Add("倚天剑");
            products.Add("屠龙刀");
            products.Add("断肠草");
            products.Add("葵花宝典");
            products.Add("四十二章经");

            AbstractObjectList objectList = new ProductList(products);      // 创建聚合对象
            AbstractIterator iterator = objectList.CreateIterator();                // 创建迭代器对象

            Console.WriteLine("正向遍历");
            while (!iterator.IsLast())
            {
                Console.Write(iterator.GetNextItem() + ",");
                iterator.Next();
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("逆向遍历");
            while (!iterator.IsFirst())
            {
                Console.Write(iterator.GetPreviousItem() + ",");
                iterator.Previous();
            }

            Console.ReadKey();
        }
    }
}
