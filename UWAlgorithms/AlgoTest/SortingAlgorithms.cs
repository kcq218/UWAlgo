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

            quickSort(test, 0, test.Length - 1);

            Assert.AreEqual(test[0], -3);
            Assert.AreEqual(test[1], -1);
            Assert.AreEqual(test[2], 0);
            Assert.AreEqual(test[3], 3);
            Assert.AreEqual(test[4], 9);
            Assert.AreEqual(test[5], 11);
        }

        // IF LOW IS LESS THAN HIGH THERE IS STILL A PIVOT
        // CALL PARTITION TO GET PIVOT
        // THEN QUICKSORT RECURSIVELY ON THE LEFT AND RIGHT SIDE OF TEST ARRAY.
        private void quickSort(int[] test, int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                int partitionIndex = partition(test, lowIndex, highIndex);

                quickSort(test, lowIndex, partitionIndex - 1);
                quickSort(test, partitionIndex + 1, highIndex);
            }
        }
        
       // START WITH TOSWAP (LOWINDEX - 1) TO GET THE INDEX OF LOWINDEX - 1
       // INCREMENT TOSWAP IF TEST[I] IS LESS THAN PIVOT
       // SWAP TOSWAP WITH TES[I] SO THAT SMALLER THAN PIVOT ELEMENT GETS REPLACED WITH NUMBER THAT IS BIGGER THAN PIVOT ELEMENT
       // IN THE END SWAP TOSWAP + 1 WITH HIGH INDEX SINCE TOSWAP + 1 IS WHERE THE PIVOT SHOULD NOW BE
       // RETURN TOSWAP + 1 SINCE IT IS THE LOCATION OF PIVOT.
        private int partition(int[] test, int lowIndex, int highIndex)
        {
            int pivot = test[highIndex];
            int toSwap = lowIndex - 1;

            for(int i = lowIndex; i < highIndex; i++)
            {
                if(test[i] < pivot)
                {
                    toSwap++;
                    var temp = test[i];
                    test[i] = test[toSwap];
                    test[toSwap] = test[i];          
                }
            }

            var temp1 = test[toSwap + 1];
            test[toSwap + 1] = test[highIndex];

            test[highIndex] = temp1;

            return toSwap + 1;
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
