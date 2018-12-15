/*If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.*/

using System;

namespace Project_Euler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 3; // sum of the multiples

            for (int i = 4; i < 1000; i++)
            {
                if (is_number_multiple_of_3_and_5(i))
                {
                    sum += i;
                }
            }
            
            Console.WriteLine(sum);
        }

        public static bool is_number_multiple_of_3_and_5(int number)
        {
            if (number % 3 == 0 || number % 5 == 0)
            {
                return true;
            }

            return false;
        }
    }
}