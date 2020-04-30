using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UWAlgorithms
{
    /**
     * N denotes input
     * 
     * 
     * O(1) does not depend on size of input
     * time to run code is the same regardless of N
     * Does not change when N changes
     * Also known as Constant time.
     * O(1) does not indicate fast, 
     * it just indicates time does not depend on size of input
     * 
     * O(N)
     * The number of iterations of the loop changes as the same rate as N
     * Linear runtime
     * Example of O(N) operations
     * Finding a max element in an unsorted array
     * Finding all elements with a certain value in an unsorted array.
     * Finding if an element exists in an unsorted array
     * 
     * O(N^2)
     * O(N^2) is more expensive than O(1) and O(N)
     * Run time grows rate of square of the input size.
     * O(N^2) is also known as quadratic.
     * 
     * Examples
     * Sum all elements in an N x N matrix.
     * Bubble sort algorithm
     * Insertion sort algorithm
     * http://bigocheatsheet.com/
     * 
     * O(log N)
     * Faster than O(N) and O(N^2)
     * log is base 2
     * rate of growth is much smaller than n
     * Run time is halved every iteration
     * 
     **/
     [TestClass]
    public class BigO
    {
        /**
         * start with 1
         * increase factor of 2 
         * multiply by 2 in each iteration
         * stopping at 1000000000
         * print value and then new line
         * how many lines does your output have?
         * increase by factor of 10 how many lines?
         * 
         * 
         * diamond
         * Week 2 Notes
         * Big O
         *
         * Average Case/ Best Case/ Worst Case
         * Big O = execution time, there is also space for Big O
         * Time vs space(Memory) cost
         * How fast they perform
         * Input size = N
         * O(1) constant time
         * O(1) can be good but also can be bad (always 1 minute)
         *
         * O(N)
         *
         *
         * O(log of n ) is usually faster than o (N) Also known as sublinear
         * O log of n is usually base 2
         * take input and do log base 2 to compare runtime based on input.
         *
         * log algorithms examples
         * find an element in sorted array(Binary Search)
         * O(log n) binary search tree is the same
         * in a balanced binary search tree
         * it'll take 10 searches worst case for 1000 element
         * it'll tkae 30 searches worst for 1 billion or 10^ 9
         *
         * N * (Log N) usually slower then N but is faster that n ^ 2
         *
         * O 2 ^ n
         *
         * Exponential
         * 2 ^ 5 is 32 operation
         * 2 ^ 6 is 64 operations
         *
         * Examples: Crypto key of two bits
         * 2 bit vs 64 bit 4 combinations vs 
         * 184,466,744,073,709,551,616
         *
         * Factorial
         * 1*2*3*4*5
         *  
         *  1. For a regular array, how many steps would it take to search for all of a certain item?
         *  For example, we want to search for every 55 contained within an array to determine how many
         *  times it appears. Give your answer in terms of n.
         *  
         *  If the input n is just a number then it is 0(1) run time and O(n) space because the Array would be fixed, 
         *  every time this algorithm is run it will run the same amount of time because it is 
         *  accumulating count of n in a fixed array. 
         *  If input is a number to search for and an
         *  array then the run time would be O(n) based on the size of the array being passed in and O(n) space.
         *  
         *  2. There’s an age old puzzle that goes as follows: You’re at a river with two buckets.
         *  One holds exactly 3 liters, and one holds exactly 5 liters. Figure out how to measure 
         *  out exactly 4 liters using those two buckets. Describe (don't code) two different algorithms
         *  for measuring out 4 liters. Which of your algorithms is more efficient? That is, 
         *  which one takes the fewest steps?
         *  
         *  Run time Complexity:  O(1) for both because they do the same amount of steps no matter the input. 
         *  Space complexity O(n) Ill be using two array for the whole algorithm.
         * 
         *  Buckets Algorithms
         *  bucket of 5  bucket of 3
         *  0          | 3
         *  3          | 0
         *  3          | 3
         *  5          | 1
         *  0          | 1
         *  1          | 0
         *  1          | 3
         *  4          | 0
         *  ************************
         *  
         *  Second Algorithm
         *  bucket of 5  bucket of 3
         *  5          | 0
         *  2          | 3
         *  2          | 0
         *  0          | 2
         *  5          | 2
         *  4          | 3
         *  
         *  3. How many steps would it take to insert the number 7 into the ordered array of [2, 4, 6, 8, 10, 12]?
         *  Describe the algorithm you used. What is the complexity of your algorithm?
         *  It would take 3 steps and I would just loop the ordered array until I find a number bigget than n
         *  Run Time Complexity: O of(n)
         *  Space complexity: O of n for var to store int that will be inserted to input array.  
         */

        [TestMethod]
        public void CompareOutput()
        {
            var result = PrintBase2(1000000000);

            Assert.AreEqual(result, 0);
        }


        public int PrintBase2(int n)
        {
            var printed = 0;
            int index = 1;
            while(index < n)
            {
                Console.WriteLine(index);
                index = index * 2;
                printed++;
            }
            Console.WriteLine(printed);
            Console.ReadLine();
            return printed;
        }

        public void printBase10(int n)
        {
            var printed = 0;
            int index = 1;
            while (index < n)
            {
                Console.WriteLine(index);
                index = index * 10;
                printed++;
            }
            Console.WriteLine(printed);
            Console.ReadLine();
        }

        // What is Big O for this function SayHiNTimes ?
        /*
           run time complexity: O of n. runtime is linear to input.
           space time complexity: O(n) int x is stored in memory.           
        */
        static void SayHiNTimes(int n)
        {
            for (int x = 0; x < n; x++)
            {
                Console.WriteLine("hi");
            }
        }

        // What is Big O for this function Sort?
        /*
           Run time Complexity: O(N^2) there will be 
           N^2 operations each time this is called.
           Space Time Complexity: O(n) fir x and y
        */
        static void Sort(int[] numbers)
        {
            for (int x = 0; x < numbers.Length; x++)
            {
                for (int y = 0; y < numbers.Length; y++)
                {
                    if (numbers[x] < numbers[y])
                    {
                        int temp = numbers[x];
                        numbers[x] = numbers[y];
                        numbers[y] = temp;
                    }
                }
            }
        }

        // What is Big O for this function Display?
        /*
           Run time Complexity: O of n. Runtime linear to input.  
           Space time complexity: O(n) for var n.
           
        */
        static void Display(int[] numbers)
        {
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }

        // What is Big O for this function PrintFirstItemThenFirstHalfThenSayHi100Times?
        /*
          Run time O(N) due to N itterating while less than middle index   
          Space time O(n) for var index and middlefinger
        */
        static void PrintFirstItemThenFirstHalfThenSayHi100Times(int[] theArray)
        {
            Console.WriteLine(theArray[0]);

            int middleIndex = theArray.Length / 2;
            int index = 0;

            while (index < middleIndex)
            {
                Console.WriteLine(theArray[index]);
                index++;
            }

            for (int x = 0; x < 100; x++)
            {
                Console.WriteLine("hi");
            }
        }
    }
}
