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

        // 1. Write a method that takes in a list of integers and returns their sum
        /**
         * if stack is empty return sum
         * else add to sum
         * return stack with the top element popped off.
        **/
        public static int Sum(Stack<int> values)
        {
                
            if(values.Count == 0)  return 0;
            else
            {
                
                return Sum(values.Pop());
            }
        }

        // 2. Write a method that determines if the passed string is a palindrome or not
        public static bool IsPalindrome(string input)
        {
            return false;
        }

        // 3. Implement a recursive method to count how many possible ways a child can 
        //    run up n stairs 1 step, 2 steps, or 3 steps at a time.
        public static int StepWays(int steps)
        {
            // Leave this execution counter inside of your recursive method
            _counter++;
            //Begin main method body below here:
            return 0;
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