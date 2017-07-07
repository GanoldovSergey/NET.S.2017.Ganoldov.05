using System;
using NUnit.Framework;

namespace Logic.NUnitTests
{
    public class UnitTest1
    {
        #region GCD
        [TestCase(5, 15, 25, 30, 35, 40, 45, ExpectedResult = 5)]
        [TestCase(2, 15, ExpectedResult = 1)]
        [TestCase(5, 0, 25, ExpectedResult = 5)]
        [TestCase(0, 0, 0, 0, ExpectedResult = 0)]
        [TestCase(60, 15, 30, ExpectedResult = 15)]
        [TestCase(-15, 25, ExpectedResult = 5)]
        public int GCD_Success(params int[] a)
        {
            long time;
            return Class1.GCD(out time, a);
        }

        [TestCase(1)]
        [TestCase(new int[] { })]

        public void GCD_ThrowArgumentExeption(params int[] a)
        {
            long time;
            Assert.Throws<ArgumentException>(() => Class1.GCD(out time, a));
        }
        #endregion

        #region BinaryGCD
        [TestCase(5, 15, 25, 30, 35, 40, 45, ExpectedResult = 5)]
        [TestCase(2, 15, ExpectedResult = 1)]
        [TestCase(5, 0, 25, ExpectedResult = 5)]
        [TestCase(0, 0, 0, 0, ExpectedResult = 0)]
        [TestCase(60, 15, 30, ExpectedResult = 15)]
        [TestCase(-15, 25, ExpectedResult = 5)]
        public int BinaryGCD_Success(params int[] a)
        {
            long time;
            return Class1.BinaryGCD(out time, a);
        }

        [TestCase(1)]
        [TestCase(new int[] { })]

        public void BinaryGCD_ThrowArgumentExeption(params int[] a)
        {
            long time;
            Assert.Throws<ArgumentException>(() => Class1.BinaryGCD(out time, a));
        }
        #endregion
    }
}
