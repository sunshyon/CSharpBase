using System;
using System.Collections.Generic;
using System.Text;

namespace A.Search
{
    public static class SearchHelper
    {
        #region 二分法查找
        /// <summary>
        /// 二分法查找，前提是数组已正向排序
        /// </summary>
        public static int Binary(this int[] arr, int value)
        {
            var L = 0; //左索引
            var R = arr.Length - 1; //右索引
            while (L <= R)
            {
                var M = (L + R) / 2;//中间索引
                if (arr[M] == value)
                    return M;
                else if (value < arr[M])
                    R = M - 1;
                else
                    L = M + 1;
            }
            return -1;
        } 
        #endregion
    }
}
