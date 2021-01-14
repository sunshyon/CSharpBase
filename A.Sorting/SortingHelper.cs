using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Sorting
{
    public static class SortingHelper<T> where T:IComparable
    {
        #region 插入排序
        /// <summary>
        /// 直接插入排序 O(n)~O(n2) 类似于扑克牌插入
        /// 将一个记录插入到已经排好序的有序表中，从而得到一个新的、记录数增1的有序表。
        /// </summary>
        public static void StraightInsertSort(T[] arr)
        {
            for (var i = 1; i < arr.Length; i++)
            {
                T tmp = arr[i];
                for (var j = i - 1; j >= 0; j--)
                {
                    if (tmp.CompareTo(arr[j])<0) //(tmp < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        arr[j] = tmp;
                    }
                    else
                        break;
                }
            }

            #region 复杂
            //int i, j;
            //T tmp;
            //for (i = 1; i < arr.Length; i++)
            //{
            //    j = i - 1;
            //    tmp = arr[i];

            //    //index位跟前一位比较，小就把前一位插入到index位，j--循环
            //    while (j >= 0 && tmp.CompareTo(arr[j]) < 0)
            //    {
            //        arr[j + 1] = arr[j];
            //        j--;
            //    }
            //    arr[j + 1] = tmp;
            //} 
            #endregion
        }
        /// <summary>
        /// 加入哨兵版直接插入排序
        /// </summary>
        public static void StraightInsertSortWithSentry(T[] arr)
        {
            int i, j;

            for (i = 1; i < arr.Length; i++)
            {
                j = i - 1;
                arr[0] = arr[i]; // 将插入元素存放于监哨arr[0]中

                while (arr[0].CompareTo(arr[j]) < 0)
                {
                    arr[j + 1] = arr[j]; // 移动记录
                    j--;
                }

                arr[j + 1] = arr[0]; // 将插入元素插入到合适的位置
            }
        }
        #endregion

        #region 希尔排序
        /// <summary>
        /// 希尔排序 O(n1.3)
        /// 将待排序的记录分成几组，从而减少参与直接插入排序的数据量，当经过几次分组之后，记录的排列已经基本有序，这时再对所有记录实施直接插入排序
        /// </summary>
        public static void ShellSort(T[] arr)
        {
            int i, j, d;
            T tmp;

            for (d = arr.Length / 2; d >= 1; d = d / 2)
            {
                for (i = d; i < arr.Length; i++)
                {
                    j = i - d;
                    tmp = arr[i];
                    while (j >= 0 && tmp.CompareTo(arr[j]) < 0)
                    {
                        arr[j + d] = arr[j];
                        j = j - d;
                    }
                    arr[j + d] = tmp;
                }
            }
        }
        #endregion

        #region 冒泡排序
        /// <summary>
        /// 冒泡排序 O(n2)
        /// 两两比较相邻记录的关键字，如果反序则交换，直到没有反序的记录为止。
        /// </summary>
        public static void BubbleSort(T[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = 1; j < arr.Length; j++)
                {
                    if (arr[j - 1].CompareTo(arr[j])>0) //(arr[j - 1] > arr[j])
                    {
                        var tmp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = tmp;
                    }
                }
                Show(arr);
            }

            #region 复杂
            //int i, j;
            //T tmp;
            //bool isExchanged = true; //需要避免因已经有序的情况下的无意义循环判断

            //for (j = 1; j < arr.Length && isExchanged; j++) //循环n-1
            //{
            //    isExchanged = false;
            //    for (i = 0; i < arr.Length - j; i++)
            //    {
            //        //跟后一个数比较，大，就互换位置
            //        if (arr[i].CompareTo(arr[i + 1]) > 0)
            //        {
            //            tmp = arr[i];
            //            arr[i] = arr[i + 1];
            //            arr[i + 1] = tmp;
            //            isExchanged = true;
            //        }
            //    }
            //    Show(arr);
            //} 
            #endregion
        }
        #endregion

        #region 快速排序
        /// <summary>
        /// 快速排序 O(nlog2n) 
        /// 通过一趟排序将待排记录分割成独立的两部分，其中一部分记录的关键字均比另一部分记录的关键字小，则可分别对这两部分记录继续进行排序，以达到整个序列有序的目的
        /// </summary>
        /// <param name="low">起始位</param>
        /// <param name="hight">最后位</param>
        public static void QuickSort(T[] arr,int low,int high)
        {
            if (low < high)
            {
                int index = Partition(arr, low, high);
                // 对左区间递归排序
                QuickSort(arr, low, index - 1);
                // 对右区间递归排序
                QuickSort(arr, index + 1, high);
            }
        }
        /// <summary>
        /// 快速排序 核心代码
        /// </summary>
        private static int Partition(T[] arr,int low,int high)
        {
            int i = low, j = high;
            T tmp = arr[i];//确定第一个元素作为“基准值”

            while (i < j)
            {
                // 从右向左扫描直到找到比基准值小的元素
                while (i < j && arr[j].CompareTo(tmp) >= 0)
                {
                    j--;
                }
                // 将比基准值小的元素移动到基准值的左端
                arr[i] = arr[j];

                // 从左向右扫描直到找到比基准值大的元素
                while (i < j && arr[i].CompareTo(tmp) <= 0)
                {
                    i++;
                }
                // 将比基准值大的元素移动到基准值的右端
                arr[j] = arr[i];

                // 记录归位
                arr[i] = tmp;
            }
            return i;
        }
        #endregion

        #region 选择排序
        /// <summary>
        /// 选择排序 O(n2)
        /// 每一趟从待排序的记录中选出关键字最小的记录，顺序放在已排好序的记录序列的最后
        /// </summary>
        /// <param name="arr"></param>
        public static void SimpleSelectSort(T[] arr)
        {
            for (var i = 0; i < arr.Length - 1; i++)
            {
                for (var j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i].CompareTo(arr[j])>0)//(arr[i] > arr[j])
                    {
                        var tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
                Show(arr);
            }

            #region 复杂
            //int i, j, k;
            //T temp;

            //for (i = 0; i < arr.Length - 1; i++)
            //{
            //    k = i; // k用于记录每一趟排序中最小元素的索引号
            //    for (j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[j].CompareTo(arr[k]) < 0)
            //        {
            //            k = j;
            //        }
            //    }

            //    if (k != i)
            //    {
            //        // 交换arr[k]和arr[i]
            //        temp = arr[k];
            //        arr[k] = arr[i];
            //        arr[i] = temp;
            //    }
            //    Show(arr);
            //} 
            #endregion
        }
        #endregion

        #region 堆排序
        /// <summary>
        /// 堆排序 O(nlog2n)
        /// 首先将待排序的记录序列构造为一个堆，此时选择堆中所有记录的最小记录或最大记录，然后将它从堆中移出，并将剩余的记录再调整成堆，这样就又找到了次大（或次小）的记录。以此类推，直到堆中只有一个记录为止，每个记录出堆的顺序就是一个有序序列
        /// </summary>
        public static void HeapSort(T[] arr)
        {
            int n = arr.Length; // 获取序列的长度
                                // 构造初始堆
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Sift(arr, i, n - 1);
            }
            // 进行堆排序
            T temp;
            for (int i = n - 1; i >= 1; i--)
            {
                temp = arr[0];       // 获取堆顶元素
                arr[0] = arr[i];     // 将堆中最后一个元素移动到堆顶
                arr[i] = temp;       // 最大元素归位,下一次不会再参与计算

                Sift(arr, 0, i - 1); // 重新递归调整堆
            }
        }
        private static void Sift(T[] arr, int low, int high)
        {
            // i为欲调整子树的根节点索引号，j为这个节点的左孩子
            int i = low, j = 2 * i + 1;
            // temp记录根节点的值
            T temp = arr[i];

            while (j <= high)
            {
                // 如果左孩子小于右孩子，则将要交换的孩子节点指向右孩子
                if (j < high && arr[j].CompareTo(arr[j + 1]) < 0)
                {
                    j++;
                }
                // 如果根节点小于它的孩子节点
                if (temp.CompareTo(arr[j]) < 0)
                {
                    arr[i] = arr[j]; // 交换根节点与其孩子节点
                    i = j;  // 以交换后的孩子节点作为根节点继续调整其子树
                    j = 2 * i + 1;  // j指向交换后的孩子节点的左孩子
                }
                else
                {
                    // 调整完毕，可以直接退出
                    break;
                }
            }
            // 使最初被调整的节点存入正确的位置
            arr[i] = temp;
        }
        #endregion

        #region 二路归并排序
        /// <summary>
        /// 二路归并排序O(nlog2n)
        /// 利用两个有序序列的合并实现归并排序
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low"></param>
        /// <param name="high"></param>
        public static void MergeSort(T[] arr, int low, int high)
        {
            if (low < high)
            {
                int mid = (low + high) / 2;
                MergeSort(arr, low, mid);       // 归并左边的子序列（递归）
                MergeSort(arr, mid + 1, high);  // 归并右边的子序列（递归）
                Merge(arr, low, mid, high);     // 归并当前前序列
            }
        }

        private static void Merge(T[] arr, int low, int mid, int high)
        {
            // result为临时空间，用于存放合并后的序列
            T[] result = new T[high - low + 1];
            int i = low, j = mid + 1, k = 0;
            // 合并两个子序列
            while (i <= mid && j <= high)
            {
                if (arr[i].CompareTo(arr[j]) < 0)
                {
                    result[k++] = arr[i++];
                }
                else
                {
                    result[k++] = arr[j++];
                }
            }
            // 将左边子序列的剩余部分复制到合并后的序列
            while (i <= mid)
            {
                result[k++] = arr[i++];
            }
            // 将右边子序列的剩余部分复制到合并后的序列
            while (j <= high)
            {
                result[k++] = arr[j++];
            }
            // 将合并后的序列覆盖合并前的序列
            for (k = 0, i = low; i <= high; k++, i++)
            {
                arr[i] = result[k];
            }
        }
        #endregion

        public static void Show(T[] arr)
        {
            for (var i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString() + " ");
            }
            Console.WriteLine("");
        }
    }
}
