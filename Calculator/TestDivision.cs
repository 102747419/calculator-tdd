using NUnit.Framework;


namespace Calculator
{
    [TestFixture]
    public class TestDivision
    {
        private Division division;
        [SetUp]
        public void SetUp()
        {
            division = new Division();
        }
        [TestCase(1, 2, 0.5)]
        [TestCase(4, 0.5, 8)]
        public void TestDividingBothPositive(decimal first, decimal second, decimal result)
        {
            Assert.AreEqual(result, division.Calculate(first, second));
        }
        [TestCase(-2, 8, -0.25)]
        [TestCase(-6, 3, -2)]
        public void TestDividingPositiveNegative(decimal first, decimal second, decimal result)
        {
            Assert.AreEqual(result, division.Calculate(first, second));
        }
        [TestCase(-8, -2, 4)]
        public void TestDividingBothNegative(int first, int second, int result)
        {
            Assert.AreEqual(result, division.Calculate(first, second));
        }

    }
}