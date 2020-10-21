using System;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //var arr = InitializeData(10000);
            //Utility.CodeTimerHelper.Time("插值", 1, () =>
            //{
            //    SortingHelper<int>.StraightInsertSort(arr);
            //});
            var arr1=InitializeData(100000);
            Utility.CodeTimerHelper.Time("希尔排序", 1, () =>
            {
                SortingHelper<int>.ShellSort(arr1);
            });
            //var arr2 = InitializeData(10000);
            //Utility.CodeTimerHelper.Time("冒泡", 1, () =>
            //{
            //    SortingHelper<int>.BubbleSort(arr2);
            //});
            var arr3 = InitializeData(100000);
            Utility.CodeTimerHelper.Time("快速排序", 1, () =>
            {
                SortingHelper<int>.QuickSort(arr3,0, arr3.Length - 1);
            });
            var arr4 = InitializeData(100000);
            Utility.CodeTimerHelper.Time("堆排序", 1, () =>
            {
                SortingHelper<int>.HeapSort(arr4);
            });
            //PrintData(arr3);

            int[] arrTest = { 5, 4, 3, 2, 1 };
            SortingHelper<int>.BubbleSort(arrTest);
            PrintData(arrTest);

            //ConsoleColor currentForeColor = Console.ForegroundColor;
            //Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hello World!");
        }

        #region 帮助函数
        static int[] InitializeData(int length = 100000)
        {
            int[] arrNumber = new int[length];
            // 首先生成有序数组进行初始化
            for (int i = 0; i < length; i++)
            {
                arrNumber[i] = i;
            }
            Random rand = new Random();
            // 随机将数组中的数字打乱顺序
            for (int i = 0; i < length; i++)
            {
                int randIndex = rand.Next(i, length);
                // 交换两个数字
                int temp = arrNumber[i];
                arrNumber[i] = arrNumber[randIndex];
                arrNumber[randIndex] = temp;
            }

            return arrNumber;
        }
        static void PrintData(int[] arr)
        {
            Console.WriteLine("----------------------------------------------------\r\n");
            for (int i = 0, count = 1; i < arr.Length; i++, count++)
            {
                if (count % 10 == 0)
                {
                    count = 1;
                    Console.Write(arr[i]);
                    Console.WriteLine();
                }
                else
                {
                    count++;
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine("\r\n----------------------------------------------------");
        }
        #endregion
    }
}
