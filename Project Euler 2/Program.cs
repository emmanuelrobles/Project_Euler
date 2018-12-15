using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Emit;

namespace Project_Euler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fib = new List<int>();
            
            //base cases
            fib.Add(1);
            fib.Add(1);
            int sum = 0;
            int sum_pair = 0;
            
            
            bool sumLimitFlag = true;
            
            do
            {
                sum = fib.ElementAt(fib.Count - 2) + fib.ElementAt(fib.Count - 1);

                if (sum > 4000000)
                {
                    sumLimitFlag = false;
                }
                else
                {
                    fib.Add(sum);

                    if (sum % 2 == 0)
                    {
                        sum_pair += sum;
                    }
                    
                }
                
            } while ( sumLimitFlag);
            
            Console.WriteLine(sum_pair);
         
        }
    }
}