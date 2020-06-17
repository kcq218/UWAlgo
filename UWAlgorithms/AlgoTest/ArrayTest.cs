using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UWAlgorithms;

namespace AlgoTest
{
    [TestClass]
    public class ArrayTest
    {

        [TestMethod]
        public void testProbingTable()
        {

            var hashmap = new ProbingHashTable();

            hashmap.Add("test", "test1");
            hashmap.Add("test1", "test2");
            hashmap.Add("test2", "test3");
            hashmap.Add("test3", "test4");
            hashmap.Add("test4", "test5");
            hashmap.Add("test5", "test6");
            hashmap.Add("test6", "test7");
            hashmap.Add("test7", "test8");
            hashmap.Add("test8", "test9");
            hashmap.Add("A", "A Value");
            hashmap.Add("K", "K Value");
            hashmap.Add("U", "U Value");

            hashmap.Delete("K");
            hashmap.Delete("test");
            var result = hashmap.Lookup("test");
            var result1 = hashmap.Lookup("test1");
            var result2 = hashmap.Lookup("test2");
            var result3 = hashmap.Lookup("test3");
            var result4 = hashmap.Lookup("test4");
            var result5 = hashmap.Lookup("test5");
            var result6 = hashmap.Lookup("test6");
            var result7 = hashmap.Lookup("test7");
            var result8 = hashmap.Lookup("test8");
            var ResultU = hashmap.Lookup("U");
            var ResultK = hashmap.Lookup("K");
            var ResultA = hashmap.Lookup("A");



            Assert.AreEqual("", result);
            Assert.AreEqual("test2", result1);
            Assert.AreEqual("test3", result2);
            Assert.AreEqual("test4", result3);
            Assert.AreEqual("test5", result4);
            Assert.AreEqual("test6", result5);
            Assert.AreEqual("test7", result6);
            Assert.AreEqual("test8", result7);
            Assert.AreEqual("test9", result8);
            Assert.AreEqual("U Value", ResultU);
            Assert.AreEqual("", ResultK);
            Assert.AreEqual("A Value", ResultA);


        }

        [TestMethod]
        public void testChainingTable()
        {
            var hashmap = new ChainingHashTable();

            hashmap.Add("test", "test1");
            hashmap.Add("test1", "test2");
            hashmap.Add("test2", "test3");
            hashmap.Add("test3", "test4");
            hashmap.Add("test4", "test5");
            hashmap.Add("test5", "test6");
            hashmap.Add("test6", "test7");
            hashmap.Add("test7", "test8");
            hashmap.Add("test8", "test9");
            hashmap.Add("test9", "test10");
            hashmap.Add("test10", "test11");
            hashmap.Add("test11", "test12");
            hashmap.Add("test12", "test13");
            hashmap.Add("test13", "test14");
            hashmap.Add("test14", "test15");
            hashmap.Add("test15", "test16");
            hashmap.Add("test16", "test17");
            hashmap.Add("test17", "test18");

            hashmap.Delete("test");
            var result = hashmap.Lookup("test");
            var result1 = hashmap.Lookup("test1");
            var result2 = hashmap.Lookup("test2");
            var result3 = hashmap.Lookup("test3");
            var result4 = hashmap.Lookup("test4");
            var result5 = hashmap.Lookup("test5");
            var result6 = hashmap.Lookup("test6");
            var result7 = hashmap.Lookup("test7");
            var result8 = hashmap.Lookup("test8");
            var result9 = hashmap.Lookup("test9");
            var result10 = hashmap.Lookup("test10");
            var result11 = hashmap.Lookup("test11");
            var result12 = hashmap.Lookup("test12");
            var result13= hashmap.Lookup("test13");
            var result14= hashmap.Lookup("test14");
            var result15 = hashmap.Lookup("test15");
            var result16= hashmap.Lookup("test16");
            var result17= hashmap.Lookup("test17");


            Assert.AreEqual("", result);
            Assert.AreEqual("test2", result1);
            Assert.AreEqual("test3", result2);
            Assert.AreEqual("test4", result3);
            Assert.AreEqual("test5", result4);
            Assert.AreEqual("test6", result5);
            Assert.AreEqual("test7", result6);
            Assert.AreEqual("test8", result7);
            Assert.AreEqual("test9", result8);
            Assert.AreEqual("test10", result9);
            Assert.AreEqual("test11", result10);
            Assert.AreEqual("test12", result11);
            Assert.AreEqual("test13", result12);
            Assert.AreEqual("test14", result13);
            Assert.AreEqual("test15", result14);
            Assert.AreEqual("test16", result15);
            Assert.AreEqual("test17", result16);
            Assert.AreEqual("test18", result17);

        }

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
