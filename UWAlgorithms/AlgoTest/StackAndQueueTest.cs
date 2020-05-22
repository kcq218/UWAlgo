using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgoTest
{
    [TestClass]
    public class StackAndQueueTest
    {
        [TestMethod]
        public void testRPC()
        {
        }

        public void ReversePolishCalculator()
        {
            var stack = new Stack<double>();
            while (true)
            {
                var input = Console.ReadLine().Trim();
                if (input == "+")
                {
                    stack.Push(stack.Pop() + stack.Pop());
                }
                else if (input == "*")
                {
                    stack.Push(stack.Pop() * stack.Pop());
                }
                else if (input == "//")
                {
                    stack.Push(stack.Pop() / stack.Pop());
                }
                else
                {
                    int result = int.Parse(input);
                    stack.Push(result);
                }
            }
        }

        public int removeMax(Stack<int> values)
        {
            var workQueue = new Queue<int>();
            var biggest = 0;

            for(int i = 0; i < values.Count; i++)
            {
                var num = values.Pop();

                if(num > biggest)
                {
                    biggest = num;
                }

                workQueue.Enqueue(num);
            }

            for (int x = 0; x < values.Count; x++)
            {

                var num = workQueue.Dequeue();

                if(num != biggest)
                {
                    values.Push(num);
                }
            }

            return biggest;
        }
    }
}
