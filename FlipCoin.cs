using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1Assignment
{
    internal class FlipCoin
    {
        public static void FlipTheCoin()
        {
            Console.WriteLine("Please enter the value for number of flips");

            int head = 0;
            int tail = 0;

            double headPercentage = 0.0;
            double tailPercentage = 0.0;

            int flip = Convert.ToInt32(Console.ReadLine());

            if (flip > 0)
            {

                for (int i = 0; i < flip; i++)
                {
                    Random random = new Random();

                    int num = random.Next(2);

                    Console.WriteLine("Random numbers genertaed by system " + num);
                    switch (num)
                    {
                        case 0:
                            Console.WriteLine("It a tail");

                            tail = tail + 1;
                            break;

                        case 1:
                            Console.WriteLine("It is head");
                            head = head + 1;
                            break;

                    }
                }

                Console.WriteLine("The head Count is " + head);
                Console.WriteLine("The tail Count is " + tail);

                headPercentage = head * 100 / flip;
                tailPercentage = tail * 100 / flip;
                Console.WriteLine("Head Percentage " + headPercentage);
                Console.WriteLine("tail Percentage " + tailPercentage);
            }
        }
    }
}

