using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ABC086A_Product
    {
        // 問題文:
        // シカのAtCoDeerくんは二つの正整数 a,b を見つけました。 a とb の積が偶数か奇数か判定してください。

        // 制約:
        // 1 ≤ a,b ≤ 10000 a,b は整数
        public void Execlusion()
        {
            string[] input = Console.ReadLine().Split(' ');

            int a = int.Parse(input[0]);

            int b = int.Parse(input[1]);

            Console.WriteLine(Check(a, b) ? "Even" : "Odd");
        }

        private bool Check(int a, int b)
        {
            if(a * b % 2 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
