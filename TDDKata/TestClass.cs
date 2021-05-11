// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace TDDKata
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void SimpleTest()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("2,2");
            Assert.That(value, Is.EqualTo(4), "Wrong actual value");
        }

        [Test]
        public void WhenNull_ThenReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum(null);
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test]
        public void WhenEmpty_ThenReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("");
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test]
        public void WhenSpace_ThenReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum(" \t\n");
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test]
        public void WhenNegative_ThenReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("-2");
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test]
        public void WhenNegativeAnsSpaceRight_ThenReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("-2 ");
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test]
        public void WhenNegativeAnsSpaceLeft_ThenReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum(" -2");
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test]
        public void WhenZero_ThenReturnsZero()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("0");
            Assert.That(value, Is.EqualTo(0));
        }

        [Test]
        public void WhenZeroAndSpace_ThenReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("0 ");
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test]
        public void WhenZeroNewlineOne_ThenReturnsOne()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("0\n1");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void WhenZeroCommaOne_ThenReturnsOne()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("0,1");
            Assert.That(value, Is.EqualTo(1));
        }

        [Test]
        public void WhenZeroCommaSpaceAndOne_ThenReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("0, 1");
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test]
        public void WhenZeroAndComma_ThenReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("0,");
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test]
        public void WhenZeroAndNewline_ThenReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("0\n");
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test]
        public void WhenZeroAndPlus_ThenReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("0+");
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test]
        public void WhenPlusOne_ThenReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("+1");
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test]
        public void WhenZeroAndOneAndTwo_ThenReturnsThree()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("0,1\n2");
            Assert.That(value, Is.EqualTo(3));
        }

        [Test]
        public void WhenZeroAndOneAndTwoAndThree_ThenReturnsSix()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("0,1,2\n3");
            Assert.That(value, Is.EqualTo(6));
        }

        [Test]
        public void WhenZeroAndOneAndSpace_ThenReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("0,1 ");
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

        [Test]
        public void WhenZeroPlusOne_ThenReturnsMinusOne()
        {
            StringCalc calc = new StringCalc();
            int value = calc.Sum("0+1");
            Assert.That(value, Is.EqualTo(-1), "Wrong actual value");
        }

    }
}
