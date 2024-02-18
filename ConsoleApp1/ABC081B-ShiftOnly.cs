using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ABC081B_ShiftOnly
    {
        public void Execlusion()
        {
            // 入力される数
            int length = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split(' ');

            int resultCnt = 0;

            for(; ;)
            {
                bool check = input.All(x => int.Parse(x) % 2 == 0);

                if (!check) break;

                for(var i = 0; i < input.Length; i++)
                {
                    input[i] = (int.Parse(input[i]) / 2).ToString();
                }

                resultCnt++;
            }

            Console.WriteLine(resultCnt);

        }
    }
}
