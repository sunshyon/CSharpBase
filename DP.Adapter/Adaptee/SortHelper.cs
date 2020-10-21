using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace DP.Adapter.Adaptee
{
    /// <summary>
    /// 适配者类
    /// </summary>
    public class SortSearchHelper
    {
        #region QuickSort
        public void QuickSort(int[] arr,int low,int high)
        {
            if (low < high)
            {
                var index = Partition(arr, low, high);
                QuickSort(arr, low, index - 1);
                QuickSort(arr, index + 1, high);
            }
        }
        private int Partition(int[]arr,int low,int high)
        {
            int i = low, j = high;
            int tmp = arr[i];//确定第一个元素作为“基准值”

            while (i < j)
            {
                // 从右向左扫描直到找到比基准值小的元素
                while (i < j && arr[j] >= tmp)
                    j--;
                // 将比基准值小的元素移动到基准值的左端
                arr[i] = arr[j];

                // 从左向右扫描直到找到比基准值大的元素
                while (i < j && arr[i] <= tmp)
                    i++;
                // 将比基准值大的元素移动到基准值的右端
                arr[j] = arr[i];

                // 记录归位
                arr[i] = tmp;
            }
            return i;
        }
        #endregion

        #region BinarySearch
        /// <summary>
        /// 二分法查找，通常是查处记录关键字升序
        /// </summary>
         public int BinarySearch(int[] arr,int key)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low < high)
            {
                int mid = (low + high) / 2;
                int midVal = arr[mid];

                if (midVal < key)
                {
                    low = mid + 1;
                }
                else if (midVal > key)
                {
                    high = mid - 1;
                }
                else
                    return 1;
            }
            return -1;
        }

        #endregion
    }
}
