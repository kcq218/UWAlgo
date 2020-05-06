﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UWAlgorithms;

namespace AlgoTest
{
    [TestClass]
    public class RecursionStep 
    {

        [TestMethod]
        public void testSum()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            var recursion = new Recursion();
            var result = recursion.Sum(stack);

            Assert.AreEqual(6, result);
        }
    }
}
