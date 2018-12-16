/*The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Euler_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(primeFactors(600851475143).Max());
        }

        public static HashSet<long> primeFactors(long n)
        {
            HashSet<long> factors = new HashSet<long>();
            
            while (n%2 == 0)
            {
                factors.Add(2);
                n = n / 2;
            }

            for (int i = 3; i <= Math.Sqrt(n); i+=2)
            {
                while (n % i == 0)
                {
                    factors.Add(i);
                    n /= i;
                }
            }

            if (n > 2)
            {
                factors.Add(n);
            }

            return factors;
        }
        
     

    }
}