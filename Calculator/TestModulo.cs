using NUnit.Framework;

namespace Calculator
{
    [TestFixture]
    public class TestModulo
    {
        private Modulo _modulo;

        [SetUp]
        public void SetUp()
        {
            _modulo = new Modulo();
        }

        [TestCase(5, 2, 1)]
        [TestCase(5.2, 2.3, 0.6)]
        public void TestModuloBothPositive(decimal first, decimal second, decimal result)
        {
            Assert.AreEqual(result, _modulo.Calculate(first, second));
        }

        [TestCase(-5, -2, -1)]
        [TestCase(-5.2, -2.3, -0.6)]
        public void TestModuloBothNegative(decimal first, decimal second, decimal result)
        {
            Assert.AreEqual(result, _modulo.Calculate(first, second));
        }

        [TestCase(5, -2, 1)]
        [TestCase(5.2, -2.3, 0.6)]
        public void TestModuloPositiveNegative(decimal first, decimal second, decimal result)
        {
            Assert.AreEqual(result, _modulo.Calculate(first, second));
        }

        [TestCase(-5, 2, -1)]
        [TestCase(-5.2, 2.3, -0.6)]
        public void TestModuloNegativePositive(decimal first, decimal second, decimal result)
        {
            Assert.AreEqual(result, _modulo.Calculate(first, second));
        }

        [TestCase(0, 1, 0)]
        [TestCase(0, -1, 0)]
        [TestCase(0, 3.14, 0)]
        [TestCase(0, -3.14, 0)]
        public void TestModuloFirstZero(decimal first, decimal second, decimal result)
        {
            Assert.AreEqual(result, _modulo.Calculate(first, second));
        }

        [TestCase(1, 0, 1)]
        [TestCase(-1, 0, -1)]
        [TestCase(3.14, 0, 3.14)]
        [TestCase(-3.14, 0, -3.14)]
        public void TestModuloSecondZero(decimal first, decimal second, decimal result)
        {
            Assert.AreEqual(result, _modulo.Calculate(first, second));
        }

        [TestCase(0, 0, 0)]
        public void TestModuloBothZero(decimal first, decimal second, decimal result)
        {
            Assert.AreEqual(result, _modulo.Calculate(first, second));
        }
    }
}