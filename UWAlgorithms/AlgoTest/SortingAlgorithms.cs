using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTest
{
    [TestClass]
    class SortingAlgorithms
    {
        [TestMethod]
        public void testMergeSort()
        {
            int[] test = new int[] { 0, -1, -3, 9, 11, 3 };

            mergsort(test);

            Assert.AreEqual(test[0], -3);
            Assert.AreEqual(test[1], -1);
            Assert.AreEqual(test[2], 0);
            Assert.AreEqual(test[3], 3);
            Assert.AreEqual(test[4], 9);
            Assert.AreEqual(test[5], 11);
        }

        private void mergsort(int[] test)
        {
            doMergeSort(test, 0, test.Length - 1);
        }

        private void doMergeSort(int[] test, int v1, int v2)
        {
            var middle = (v2 - v1) / 2; 
            
            if(middle > v1)
            {
                doMergeSort(test,v1, middle);
                doMergeSort(test, middle, v2);
                merge()
            }
        }
    }
}
