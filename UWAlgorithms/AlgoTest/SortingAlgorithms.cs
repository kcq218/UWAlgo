using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTest
{
    [TestClass]
    public class SortingAlgorithms
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

        [TestMethod]
        public void testQuickSort()
        {
            int[] test = new int[] { 0, -1, -3, 9, 11, 3 };

            quickSort(test);

            Assert.AreEqual(test[0], -3);
            Assert.AreEqual(test[1], -1);
            Assert.AreEqual(test[2], 0);
            Assert.AreEqual(test[3], 3);
            Assert.AreEqual(test[4], 9);
            Assert.AreEqual(test[5], 11);
        }

        private void quickSort(int[] test)
        {
            throw new NotImplementedException();
        }

        public void mergsort(int[] test)
        {
            doMergeSort(test, 0, test.Length - 1);
        }

        private void doMergeSort(int[] test, int v1, int v2)
        {
            var middle = v1 + (v2 - v1) / 2; 
            
            if(v1 < v2)
            {
                doMergeSort(test,v1, middle);
                doMergeSort(test, middle+1, v2);
                merge(test, v1, middle, v2);
            }
        }

        private void merge(int[] test, int v1, int middle, int v2)
        {
            int[] copyarr = new int[middle - v1 + 1];
            int[] copyarr2 = new int[v2 - middle];

            for(int i = 0; i < middle - v1 + 1; i++)
            {
                copyarr[i] = test[i + v1];
            }

            for (int x = 0; x < v2 - middle; x++)
            {
                copyarr2[x] = test[middle + 1 + x];
            }

            var index0 = 0;
            var index2 = 0;
            var indexTest = v1;

            while(index0 < copyarr.Length && index2 < copyarr2.Length && indexTest < test.Length)
            {
                if (copyarr[index0] < copyarr2[index2])
                {
                    test[indexTest] = copyarr[index0];
                    index0++;
                }
                else
                {
                    test[indexTest] = copyarr2[index2];
                    index2++;
                }

                indexTest++;
            }

            while(index0 < copyarr.Length)
            {
                test[indexTest] = copyarr[index0];

                index0++;
                indexTest++;
            }

            while (index2 < copyarr2.Length)
            {
                test[indexTest] = copyarr2[index2];

                index2++;
                indexTest++;
            }
        }
    }
}
