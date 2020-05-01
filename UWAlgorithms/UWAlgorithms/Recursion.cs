using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UWAlgorithms
{
    public class Recursion
    {
        public Recursion()
        {

        }

        public int Fibonacci(int n)
        {
            var cache = new int[n];

            if(n == 0)
            {
                return 0;
            }

            if(n <= 2)
            {
                return 1;
            }

            if(!cache.Contains(n))
            {
                cache[n - 1] = Fibonacci(n - 1) + Fibonacci(n - 2); 
            }                       
            
            return cache[n - 1];                   
        }

        public int Factorial(int n)
        {
            var cache = new int[n];

            if (n <= 1)
            {
                return 0;
            }

            if (!cache.Contains(n))
            {
                cache[n - 1] = n * Factorial(n - 1);
            }

            return cache[n - 1];
        }
    }
}
