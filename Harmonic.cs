using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    internal class Harmonic
    {
        public static void Harm()
        {
            Console.WriteLine("Please enter the number for harmonic output : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine("The number entered should not be zero");
            }
            else
            {
                double sum = 0.0;

                for (int i = 1; i <= n; i++)
                {
                    sum += 1.0 / i;
                    Console.WriteLine("The " + i + "th Harmonic number is : ");
                    Console.WriteLine("1.0 /" + i + " = " + sum);
                }
            }

        }
    }
}
