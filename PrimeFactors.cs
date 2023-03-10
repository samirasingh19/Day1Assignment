using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    internal class PrimeFactors
    {
        public static void PrimeFactor()
        {
            Console.WriteLine("Enter a number to find the prime factors: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime factors of " + n + ": ");

            for (int i = 2; i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i + " ");
                    n /= i;
                }
            }
            if (n > 1)
            {

                Console.WriteLine(n);
            }
        }
    }
}
