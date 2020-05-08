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
        public int Sum(Stack<int> values)
        {
                
            if(values.Count == 0)  return 0;
            else
            {
                
                return values.Pop() + Sum(values);
            }
        }

        // 2. Write a method that determines if the passed string is a palindrome or not
        // if string.length = 0 return true
        // else
        // check to see if beginning and ending string are the same.
        // call isPalindrome again
        public  bool IsPalindrome(string input)
        {
            input = input.Replace(" ", "");

            if (input.Length == 0 || input.Length == 1)
            {
                return true;
            }
            else
            {
                if(input[0] == input[input.Length-1])
                {
                    var sb = new StringBuilder();

                    for(int i = 1; i < input.Length - 1; i++)
                    {
                        sb.Append(input[i]);
                    }
                    return IsPalindrome(sb.ToString());
                }
            }
            return false;
        }

        // 3. Implement a recursive method to count how many possible ways a child can 
        //    run up n stairs 1 step, 2 steps, or 3 steps at a time.
        public static int StepWays(int steps)
        {
            // Leave this execution counter inside of your recursive method
            //_counter++;
            //Begin main method body below here:
            return 0;
        }
        
        public int stepCount(int stepsToTake, int steps)
        {
            return stepCount(stepsToTake + 1, steps) + stepCount(stepsToTake + 2, steps) + stepCount(stepsToTake + 2, steps);
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