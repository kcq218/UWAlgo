using System;
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
    }
}