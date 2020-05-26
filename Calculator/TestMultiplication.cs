using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    public class TestMultiplication
    {
        private Multiplication multiplication;
        [SetUp]
        public void SetUp()
        {
            multiplication = new Multiplication();
        }

        [TestCase(2, 1, 2)]
        [TestCase(0.5, 0.7, 0.35)]
        public void TestMultiplyingBothPositive(decimal first, decimal second, decimal result)
        {
            Assert.AreEqual(result, multiplication.Calculate(first, second));
        }

        [TestCase(-4, 3.1, -12.4)]
        [TestCase(6, -2.2, -13.2)]
        public void TestMultiplyingPositiveNegative(decimal first, decimal second, decimal result)
        {
            Assert.AreEqual(result, multiplication.Calculate(first, second));
        }

        [TestCase(-5, -7, 35)]
        public void TestMultiplyingBothNegative(int first, int second, int result)
        {
            Assert.AreEqual(result, multiplication.Calculate(first, second));
        }

    }
}
