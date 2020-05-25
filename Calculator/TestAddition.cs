﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    [TestFixture]
    public class TestAddition
    {
        private Addition addition;
        [SetUp]
        public void SetUp()
        {
            addition = new Addition();
        }
        [TestCase(1, 2, 3)]
        [TestCase(0.1,0.2,0.3)]
        public void Addding_Positive_Numbers(decimal first, decimal second, decimal result)
        {
            Assert.AreEqual(result, addition.Calculate(first, second));
        }
        [TestCase(-2,3.5,1.5)]
        [TestCase(-3.5,2,-1.5)]
        public void Addding_negative_positive_Numbers(decimal first, decimal second, decimal result)
        {
            Assert.AreEqual(result, addition.Calculate(first, second));
        }
        [TestCase(-3,-4,-7)]
        public void Adding_both_negative_Numbers(int first, int second, int result)
        {
            Assert.AreEqual(result, addition.Calculate(first, second));
        }

    }
}
