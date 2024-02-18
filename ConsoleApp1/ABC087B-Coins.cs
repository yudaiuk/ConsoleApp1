using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ABC087B_Coins
    {
        public void Execlusion()
        {
            int fiveHundred = int.Parse(Console.ReadLine());
            int oneHundred = int.Parse(Console.ReadLine());
            int fifty = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            int resultCnt = 0;

            for(int a = fiveHundred; a >= 0; a--)
            {
                for(int b = oneHundred; b >= 0; b--)
                {
                    for(int c = fifty; c >= 0; c--)
                    {
                        if((500 * a + 100 * b + 50 * c) == num)
                        {
                            resultCnt++;
                        }
                    }
                }
            }

            Console.WriteLine(resultCnt);
            
        }
    }
}
