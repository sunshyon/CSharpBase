using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Interview
{
    public class Test20201012
    {
        /// <summary>
        /// 单词出现频率
        /// </summary>
        private static Dictionary<string, float> TermFrequency(string str)
        {
            var arr = str.Split(' ');
            float n = arr.Length;
            var dic = new Dictionary<string, float>();
            for (var i = 0; i < arr.Length; i++)
            {
                var item = arr[i];
                if (!dic.ContainsKey(item))
                {
                    dic.Add(item, 1 / n);
                }
                else
                {
                    dic[item] = (dic[item] * n + 1) / n;
                }
            }
            return dic;
        }
        /// <summary>
        /// 二分法查找
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="low">开始索引</param>
        /// <param name="high">结束索引</param>
        /// <param name="key">查找对象</param>
        public static int BinarySearch(int[] arr, int low, int high, int key)
        {
            int mid = (low + high) / 2;
            if (low > high)
                return -1;
            else
            {
                if (arr[mid] == key)
                    return mid;
                else if (arr[mid] > key)
                    return BinarySearch(arr, low, mid - 1, key);
                else
                    return BinarySearch(arr, mid + 1, high, key);
            }
        }
        /// <summary>
        /// 一维数组转二维
        /// </summary>
        private static int[,] shuzu(int[] arr)
        {
            var n = arr.Length;
            var r = n / 3 + 1;
            int[,] b = new int[r, 3];
            for (int i = 0; i < n; i++)
            {
                b[i / 3, i % 3] = arr[i];
            }
            return b;
        }

        private static string reversal(string str)
        {
            var arr = str.Split(' ');
            var newArr = arr.Reverse();
            var newStr = "";
            foreach (var item in newArr)
            {
                newStr += item + " ";

            }
            newStr = newStr.Substring(0, newStr.Length - 1);
            return newStr;
        }
    }

}
