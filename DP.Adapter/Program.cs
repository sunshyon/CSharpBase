using DP.Adapter.Adaptee;
using DP.Adapter.Adapter;
using System;

namespace DP.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1,2,3,4,5 };
            //var a=new SortSearchHelper().BinarySearch(arr, 4);

            var operate = new OperationAdapter();
            operate.Search(arr, 2);

            Console.WriteLine("Hello World!");
        }
    }
}
