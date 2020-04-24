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
         * Space Complexity
         * O(1) does not allocate extra space based on input.
         * 
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
    }
}
