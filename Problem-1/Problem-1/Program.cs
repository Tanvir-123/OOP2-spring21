using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int N, i;
            Console.WriteLine("Enter the Countable even Number : ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----------------------------------");

            for (i = 1; i <= N; i++)
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }


            Console.ReadLine();

        }
    }
}
