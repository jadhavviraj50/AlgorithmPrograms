using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PrimeNumber
    {
        public void PrimeNumberWithinRange()
        {
            int num, cnt = 0;
            Console.WriteLine("Find The Prime Number Within Range of number:  ");
            Console.WriteLine("Input Starting Number Of Range: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Ending Number Of Range: ");
            int end = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Prime Number Between {0} and {1} are: ", start, end);

            for (num = start; num <= end; num++)
            {
                cnt = 0;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        cnt++;
                        break;
                    }
                }
                if (cnt == 0 && num != 1)
                {
                    Console.Write("{0} ", num);
                }
            }
            Console.WriteLine("\n");
        }
    }
}
