using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Strings
    {

        /// <summary>
        /// 罗马数字转整数
        /// 罗马数字包含以下七种字符: I， V， X， L，C，D 和 M。
        ///         字符 数值
        ///         I             1
        ///         V             5
        ///         X             10
        ///         L             50
        ///         C             100
        ///         D             500
        ///         M             1000
        ///例如， 罗马数字 2 写做 II ，即为两个并列的 1。12 写做 XII ，即为 X + II 。 27 写做 XXVII, 即为 XX + V + II 。
        ///通常情况下，罗马数字中小的数字在大的数字的右边。但也存在特例，例如 4 不写做 IIII，而是 IV。数字 1 在数字 5 的左边，所表示的数等于大数 5 减小数 1 得到的数值 4 。同样地，数字 9 表示为 IX。这个特殊的规则只适用于以下六种情况：
        ///        I 可以放在 V(5) 和 X(10) 的左边，来表示 4 和 9。
        ///        X 可以放在 L(50) 和 C(100) 的左边，来表示 40 和 90。 
        ///        C 可以放在 D(500) 和 M(1000) 的左边，来表示 400 和 900。
        ///        给定一个罗马数字，将其转换成整数。输入确保在 1 到 3999 的范围内。
        ///        
        /// 示例 1:
        ///输入: "III"
        ///输出: 3
        ///示例 2:
        ///
        ///输入: "IV"
        ///输出: 4
        ///示例 3:
        ///
        ///输入: "IX"
        ///输出: 9
        ///示例 4:
        ///
        ///输入: "LVIII"
        ///输出: 58
        ///解释: L = 50, V= 5, III = 3.
        ///示例 5:
        ///
        ///输入: "MCMXCIV"
        ///输出: 1994
        ///解释: M = 1000, CM = 900, XC = 90, IV = 4.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int RomanToInt(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            //基础数据字典
            Dictionary<char, int> dicKeyValue = new Dictionary<char, int>();
            dicKeyValue.Add('I', 1);
            dicKeyValue.Add('V', 5);
            dicKeyValue.Add('X', 10);
            dicKeyValue.Add('L', 50);
            dicKeyValue.Add('C', 100);
            dicKeyValue.Add('D', 500);
            dicKeyValue.Add('M', 1000);

            int result = 0;
            //从前往后遍历
            for (int index = 0; index < s.Length; index++)
            {
                if (index + 1 < s.Length && dicKeyValue[s[index]] < dicKeyValue[s[index + 1]])//数字小的 在数字大的前面
                {
                    result += dicKeyValue[s[index + 1]] - dicKeyValue[s[index]];
                    index++;
                }
                else
                {
                    result += dicKeyValue[s[index]];
                }
            }

            return result;
        }

        /// <summary>
        /// 编写一个函数来查找字符串数组中的最长公共前缀。
        ///
        ///    如果不存在公共前缀，返回空字符串 ""。
        ///
        ///    示例 1:
        ///
        ///    输入: ["flower","flow","flight"]
        ///            输出: "fl"
        ///    示例 2:
        ///
        ///    输入: ["dog","racecar","car"]
        ///            输出: ""
        ///    解释: 输入不存在公共前缀。
        ///    说明:
        ///
        ///    所有输入只包含小写字母 a-z 。
        /// </summary>
        /// <param name="strs"></param>
        /// <returns></returns>
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            int minLength = strs[0].Length;
            for (int index = 1; index < strs.Length; index++)
            {
                if (minLength > strs[index].Length)
                    minLength = strs[index].Length;
            }
            char[] chars = new char[minLength];
            bool returnFlag = false;
            for (int index = 0; index < minLength; index++)
            {
                foreach (string str in strs)
                {
                    if (chars[index] == '\0')
                    {
                        chars[index] = str[index];
                    }
                    else if (chars[index] != str[index])
                    {
                        chars[index] = '\0';
                        returnFlag = true;
                        break;
                    }
                    
                }
                if (returnFlag)
                    break;
            }
            return (new string(chars)).TrimEnd('\0');

        }

    }
}
