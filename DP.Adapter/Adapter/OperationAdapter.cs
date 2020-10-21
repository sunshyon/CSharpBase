using DP.Adapter.Adaptee;
using DP.Adapter.Target;
using System;
using System.Collections.Generic;
using System.Text;

namespace DP.Adapter.Adapter
{
    /// <summary>
    /// 适配器
    /// </summary>
    public class OperationAdapter : IScoreOperation
    {
        private SortSearchHelper sortSearchHelper;
        public OperationAdapter()
        {
            sortSearchHelper = new SortSearchHelper();
        }
        public int Search(int[] array, int key)
        {
            return sortSearchHelper.BinarySearch(array, key);
        }

        public void Sort(int[] array)
        {
            sortSearchHelper.QuickSort(array, 0, array.Length-1);
        }
    }
}
