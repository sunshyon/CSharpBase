using System;
using System.Collections.Generic;
using System.Text;

namespace A.Fuck
{
    /// <summary>
    /// 动态规划算法示例
    /// </summary>
    public class DynamicPlan
    {
        #region 斐波拉契数列
        /// <summary>
        /// 普通斐波拉契数列 时间复杂度O(2^n)
        /// </summary>
        public int OrdinaryFib(int n)
        {
            if (n == 1 || n == 2) return 1;
            return OrdinaryFib(n - 1) + OrdinaryFib(n - 2);
        }
        /// <summary>
        /// 带备忘录的斐波拉契数列，时间复杂度O(n)
        /// 可大大提高效率 --原理是用字典存下以及算过的节点值
        /// </summary>
        public int Fib(int n)
        {
            if (n < 1) return 0;
            var dic = new Dictionary<int, int>();
            return FibHelper(dic, n);
        }
        public int FibHelper(Dictionary<int, int> dic, int n)
        {
            if (n == 1 || n == 2) return 1;
            if (dic.ContainsKey(n)) return dic[n];
            var val = FibHelper(dic, n - 1) + FibHelper(dic, n - 2);
            dic.Add(n, val);
            return dic[n];
        }
        /// <summary>
        /// 斐波拉契数列最快解
        /// 利用「状态压缩」
        /// </summary>
        public int Fib3(int n)
        {
            if (n < 1) return 0;
            if (n == 2 || n == 1)
                return 1;
            int prev = 1, curr = 1;
            for (int i = 3; i <= n; i++)
            {
                int sum = prev + curr;
                prev = curr;
                curr = sum;
            }
            return curr;
        }
        #endregion

        /// <summary>
        /// 最小覆盖字串 利用「滑动窗口」 双指针  未完成
        /// </summary>
        /// <returns></returns>
        public void MinSubString()
        {
            //找出包含t所有字母的最小字串  --结果是：BANC
            var str = "ADOBECODEBANC";
            var t = "ABC";
            var sList = str.ToCharArray();

            var need = new Dictionary<char, int>();//目标 need={A:1,B:1,C:1}
            foreach(var i in t.ToCharArray())
            {
                need.Add(i, 1);
            }
            var window = new Dictionary<char, int>(); //当前窗口中各字符数量

            int left = 0, right = 0;
            int valid = 0; //窗口中满足need条件字符个数

            while (right < sList.Length)
            {
                //将c移入滑动窗口中
                char c = sList[right];
                right++;
                if (t.Contains(c))
                {
                    if (window.ContainsKey(c))
                        window[c]++;
                    else
                    {
                        window.Add(c,1);
                    }
                }
            }
        } 
    }
}
