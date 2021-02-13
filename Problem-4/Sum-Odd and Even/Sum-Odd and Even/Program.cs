using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Odd_and_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1= 0,sum= 0, i, n = 50;
            for(i=1; i<=n; i++)
            {
                sum += 2 * i;
                sum1 += (2 * i) - 1;
                Console.WriteLine("Even numbers sum is=(0)", sum);
                Console.WriteLine("Odd numbers sum is=(0)", sum1);

            }


        }
    }
}
