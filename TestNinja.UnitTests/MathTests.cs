﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;
using Math = TestNinja.Fundamentals.Math;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class MathTests
    {
        private Math _math;

        // SetUp
        // TearDown

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnFirstArgument()
        {
            var result = _math.Max(2, 1);

             Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnSecondArgument()
        {
            var result = _math.Max(1, 2);

            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            var result = _math.Max(1, 1);

            Assert.That(result, Is.EqualTo(1));
        }
    }
}
