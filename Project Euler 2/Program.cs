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
            fib.Add(2);
            int sum = 0;
            
            do
            {
                sum = fib.ElementAt(fib.Count - 2) + fib.ElementAt(fib.Count - 1);
                fib.Add(sum);
            } while ( sum < 4000000);


            foreach (var VARIABLE in fib)
            {
                Console.WriteLine(VARIABLE);
                
            }
        }
    }
}