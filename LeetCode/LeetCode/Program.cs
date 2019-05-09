using System;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 回文数
            //Console.WriteLine("验证一个数字是否是回文数(按Esc退出,按Enter开始)");
            //while (true)
            //{
            //    ConsoleKeyInfo kinfo = Console.ReadKey();
            //    if (kinfo.Key == ConsoleKey.Escape)
            //    {
            //        break;
            //    }
            //    else if (kinfo.Key == ConsoleKey.Enter)
            //    {
            //        Console.WriteLine("请输入需要验证的整数:");
            //        int input = int.Parse(Console.ReadLine());
            //        bool result = Number.IsPalindrome(input);
            //        Console.WriteLine("结果是:" + result);
            //    }
            //}
            #endregion

            #region 罗马数字转整数
            Console.WriteLine("验证一个数字是否是回文数(按Esc退出,按Enter开始)");
            while (true)
            {
                ConsoleKeyInfo kinfo = Console.ReadKey();
                if (kinfo.Key == ConsoleKey.Escape)
                {
                    break;
                }
                else if (kinfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("请输入需要转换的罗马数:");
                    string inputString = Console.ReadLine();
                    int result = Strings.RomanToInt(inputString);
                    Console.WriteLine("结果是:" + result);
                }
            }
            #endregion
        }
    }
}
