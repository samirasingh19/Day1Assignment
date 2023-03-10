using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    internal class LeapYear
    {
        public static void Leapyear()
        {
            Console.WriteLine("Please enter the year in four digit value:");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("The {0} is a Leap year.", year);
            }
            else
            {
                Console.WriteLine("The {0} is not a Leap year.", year);
            }
        }
    }
}
