using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{

    public class Number
    {
        /// <summary>
        /// 回文数
        /// 判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。
        /// 示例 1:
        ///     输入: 121
        ///     输出: true
        /// 示例 2:
        ///     输入: -121
        ///     输出: false
        ///     解释: 从左向右读, 为 -121 。 从右向左读, 为 121- 。因此它不是一个回文数。
        /// 示例 3:
        ///     输入: 10
        ///     输出: false
        ///     解释: 从右向左读, 为 01 。因此它不是一个回文数。
        ///     
        /// 你能不将整数转为字符串来解决这个问题吗？
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool IsPalindrome(int x)
        {
            //如果是负数 肯定不是一个回文数
            if (x < 0) return false;
            //个位数 肯定是一个回文数
            if (0 <= x && x < 10) return true;
            //大于10的数字
            int result = 0;
            int number = 0;
            int tempX = x;
            while (tempX > 0)//121
            {
                number = tempX % 10;//1 2 1
                result = result * 10 + number;//1 12 121
                tempX = (tempX - number) / 10;//12 1
            }
            if (result == x)
                return true;
            else
                return false;
        }

    }
}
