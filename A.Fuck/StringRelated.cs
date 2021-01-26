using System;
using System.Collections.Generic;
using System.Text;

namespace A.Fuck
{
    public class StringRelated
    {
        /// <summary>
        /// 判断是否回文字符串 -> ABCBA
        /// 利用双指针，首尾向内逼近
        /// </summary>
        public bool IsPalindrome(string str)
        {
            int left = 0, right = str.Length - 1;
            var arr = str.ToCharArray();
            while (left < right)
            {
                if (arr[left] != arr[right])
                    return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
