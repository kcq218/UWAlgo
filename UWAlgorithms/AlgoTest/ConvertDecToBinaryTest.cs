using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTest
{
    [TestClass]
    public class ConvertDecToBinaryTest
    {
        [TestMethod]
        public void TestConvert3()
        {
            var result = convert(8);

            Assert.AreEqual("1000", result);
        }

        // convert numbers into base 2 binary

        public string convert(int n)
        {
            // array to store binary number 
            int[] binaryNum = new int[32];
            StringBuilder sb = new StringBuilder();

            // counter for binary array 
            int i = 0;
            while (n > 0)
            {
                // storing remainder in 
                // binary array 
                binaryNum[i] = n % 2;
                n = n / 2;
                i++;
            }

            // printing binary array 
            // in reverse order 
            for (int j = i - 1; j >= 0; j--)
                sb.Append(binaryNum[j]);

            return sb.ToString();
        }

        [TestMethod]
        public void decodeLpuPe81bc2wTesy()
        {
            var result = ToBase10("LpuPe81bc2w");

            Assert.AreEqual(18327995462734721974, result);
        }

        const string _base62 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private static Dictionary<char, ulong> base62Mapping = new Dictionary<char, UInt64>
        {
            {'0', 0},{'1', 1},{'2', 2}, {'3', 3},{'4', 4},{'5', 5},{'6', 6},{'7', 7},{'8', 8},{'9', 9},{'A', 10},{'B', 11}, {'C', 12},{'D', 13},{'E', 14},{'F', 15},{'G', 16},{'H', 17},{'I', 18},{'J', 19},{'K', 20},{'L', 21},{'M', 22},{'N', 23},{'O', 24},{'P', 25},{'Q', 26},{'R', 27},{'S', 28},{'T', 29},{'U', 30},
            {'V', 31},{'W', 32},{'X', 33},{'Y', 34},{'Z', 35},{'a', 36},{'b', 37},{'c', 38},{'d', 39},{'e', 40},{'f', 41},{'g', 42},{'h', 43},{'i', 44},{'j', 45},{'k', 46},{'l', 47},{'m', 48},{'n', 49},{'o', 50},{'p', 51},{'q', 52},{'r', 53},{'s', 54},{'t', 55},{'u', 56},{'v', 57},{'w', 58},{'x', 59},{'y', 60},{'z', 61}
        };

        // 1. For our first problem, write a function that converts a given base-62 string
        //    into an integer. Only a single string will be provided, and it will be up to
        //    11 characters in length.  

         /**
             convert each base 62 value to digit.
             multiply digit by 62^n
             add each digit
             return sum.
        **/

        public static ulong ToBase10(string videoId)
        {
            if (videoId.Length == 0)
            {
                return 0;
            }
            

            var charArray = videoId.ToCharArray();
            var highestbase = charArray.Length - 1;
            var totalSum = (UInt64)0;
            
            for(int i = 0; i < videoId.Length; i++)
            {
                if(!_base62.Contains(charArray[i]))
                {
                    return 0;
                }

                var base62ToInteger = base62Mapping[charArray[i]];
                totalSum += base62ToInteger * (UInt64)Math.Pow(62, highestbase - i);
            }

            return totalSum;
        }

        // 2. Write a function that does the opposite of the previous one. 
        // That is, it encodes a base 10 number into base 62
        // producing a string that represents the same number.
        public static string ToBase62(ulong number)
        {
            return "";
        }
    }
}