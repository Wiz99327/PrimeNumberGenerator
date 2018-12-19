using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumberGeneratorExercise.Interfaces;
using PrimeNumberGeneratorExercise.BusinessLogic;

namespace PrimeNumberGeneratorTests
{
    [TestClass]
    public class GeneratorTests
    {
        IPrimeNumberGenerator _primeNumGenerator;

        [TestInitialize]
        public void Initialize()
        {
            _primeNumGenerator = new PrimeNumberGenerator();
        }

        [TestMethod]
        public void HappyPath_ValidNumbers_FirstLessThanSecond()
        {
            var values = _primeNumGenerator.Generate(1, 10);

            Assert.IsNotNull(values);
            Assert.AreEqual(4, values.Count);
            Assert.AreEqual(2, values[0]);
            Assert.AreEqual(3, values[1]);
            Assert.AreEqual(5, values[2]);
            Assert.AreEqual(7, values[3]);
        }

        [TestMethod]
        public void HappyPath_ValidNumbers_SecondLessThanFirst()
        {
            var values = _primeNumGenerator.Generate(10, 1);

            Assert.IsNotNull(values);
            Assert.AreEqual(4, values.Count);
            Assert.AreEqual(2, values[0]);
            Assert.AreEqual(3, values[1]);
            Assert.AreEqual(5, values[2]);
            Assert.AreEqual(7, values[3]);
        }

        [TestMethod]
        public void HappyPath_Numbers7900To7920()
        {
            var values = _primeNumGenerator.Generate(7900, 7920);

            Assert.IsNotNull(values);
            Assert.AreEqual(3, values.Count);
            Assert.AreEqual(7901, values[0]);
            Assert.AreEqual(7907, values[1]);
            Assert.AreEqual(7919, values[2]);
        }

        [TestMethod]
        public void HappyPath_First26PrimeNumbersRange()
        {
            var values = _primeNumGenerator.Generate(2, 101);

            Assert.IsNotNull(values);
            Assert.AreEqual(26, values.Count);
            Assert.AreEqual(2, values[0]);
            Assert.AreEqual(3, values[1]);
            Assert.AreEqual(5, values[2]);
            Assert.AreEqual(7, values[3]);
            Assert.AreEqual(11, values[4]);
            Assert.AreEqual(13, values[5]);
            Assert.AreEqual(17, values[6]);
            Assert.AreEqual(19, values[7]);
            Assert.AreEqual(23, values[8]);
            Assert.AreEqual(29, values[9]);
            Assert.AreEqual(31, values[10]);
            Assert.AreEqual(37, values[11]);
            Assert.AreEqual(41, values[12]);
            Assert.AreEqual(43, values[13]);
            Assert.AreEqual(47, values[14]);
            Assert.AreEqual(53, values[15]);
            Assert.AreEqual(59, values[16]);
            Assert.AreEqual(61, values[17]);
            Assert.AreEqual(67, values[18]);
            Assert.AreEqual(71, values[19]);
            Assert.AreEqual(73, values[20]);
            Assert.AreEqual(79, values[21]);
            Assert.AreEqual(83, values[22]);
            Assert.AreEqual(89, values[23]);
            Assert.AreEqual(97, values[24]);
            Assert.AreEqual(101, values[25]);
        }

        [TestMethod]
        public void HappyPath_BothInputsSamePrimeNumber()
        {
            var values = _primeNumGenerator.Generate(5, 5);

            Assert.IsNotNull(values);
            Assert.AreEqual(1, values.Count);
            Assert.AreEqual(5, values[0]);
        }

        [TestMethod]
        public void HappyPath_PrimeNumbersBetween4And37()
        {
            var values = _primeNumGenerator.Generate(4, 37);

            Assert.IsNotNull(values);
            Assert.AreEqual(10, values.Count);
            Assert.AreEqual(5, values[0]);
            Assert.AreEqual(7, values[1]);
            Assert.AreEqual(11, values[2]);
            Assert.AreEqual(13, values[3]);
            Assert.AreEqual(17, values[4]);
            Assert.AreEqual(19, values[5]);
            Assert.AreEqual(23, values[6]);
            Assert.AreEqual(29, values[7]);
            Assert.AreEqual(31, values[8]);
            Assert.AreEqual(37, values[9]);
        }

        [TestMethod]
        public void Negative_ZeroesEntered()
        {
            var values = _primeNumGenerator.Generate(0, 0);

            Assert.IsNotNull(values);
            Assert.AreEqual(0, values.Count);
        }

        [TestMethod]
        public void Negative_OnesEntered()
        {
            var values = _primeNumGenerator.Generate(1, 1);

            Assert.IsNotNull(values);
            Assert.AreEqual(0, values.Count);
        }

        [TestMethod]
        public void Negative_BothNumbersSameComposite()
        {
            var values = _primeNumGenerator.Generate(6, 6);

            Assert.AreEqual(0, values.Count);
        }

        [TestMethod]
        public void Negative_StartValue_NegativeNumberEntered()
        {
            var values = _primeNumGenerator.Generate(-1, 3);

            Assert.AreEqual(0, values.Count);
        }

        [TestMethod]
        public void Negative_EndValue_NegativeNumberEntered()
        {
            var values = _primeNumGenerator.Generate(5, -1);

            Assert.AreEqual(0, values.Count);
        }

        [TestMethod]
        public void Negative_StartEndValue_NegativeNumberEntered()
        {
            var values = _primeNumGenerator.Generate(-1, -5);

            Assert.AreEqual(0, values.Count);
        }
    }
}
