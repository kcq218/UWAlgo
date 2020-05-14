using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTest
{
    [TestClass]
    public class ArrayTest
    {

        [TestMethod]
        public void testPalindrome()
        {
            var list = new List<int> 
            {
                5, 10, 15, 20
            };
            var list1 = new List<int>
            {
                3, 7, 13, 60
            };

            var result = MergeSortedList(list, list1);

            Assert.AreEqual(3, result[0]);
            Assert.AreEqual(5, result[1]);
            Assert.AreEqual(7, result[2]);
            Assert.AreEqual(10, result[3]);
            Assert.AreEqual(13, result[4]);
            Assert.AreEqual(15, result[5]);
            Assert.AreEqual(20, result[6]);
            Assert.AreEqual(60, result[7]);

        }

        public List<int> MergeSortedList(List<int> list1, List<int> list2)
        {
            var mergedList = new List<int>();

            foreach (var num in list1)
            {
                mergedList.Add(num);
            }

            foreach (var num in list2)
            {
                mergedList.Add(num);
            }

            bubbleSort(mergedList);

            return mergedList;
        }

        public static void bubbleSort(List<int> inputList)
        {
            var count = inputList.Count;

            for (int i = 0; i < count - 1; i++)
            {
                var big = false;

                for (int x = 0; x < count - i - 1; x++)
                {
                    if (inputList[x] > inputList[x + 1])
                    {
                        var temp = inputList[x];
                        inputList[x] = inputList[x + 1];
                        inputList[x + 1] = temp;
                        big = true;
                    }
                }

                if (big == false) break;
            }
        }

        // if head is null or head.next is null return head
        // call reverse until you get the head of reversed list
        // point head.next.next pointer to head
        // point head.next to null because it is the next one to be reversed
        // return the head node you saved. 
        //public LinkedListNode<int> reverse(LinkedListNode<int> head)
        //{
        //    if (head == null || head.Next == null)
        //    {
        //        return head;
        //    }

        //    var reverseListNode =  reverse(head.Next);
        //    head.Next.Next = head;
        //    head.Next = null;

        //    return reverseListNode;
        //}
    }
}
