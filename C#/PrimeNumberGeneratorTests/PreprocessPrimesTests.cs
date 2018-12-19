using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumberGeneratorExercise.BusinessLogic;

namespace PrimeNumberGeneratorTests
{
    [TestClass]
    public class PreprocessPrimesTests
    {
        PrimeNumberGenerator _primeNumGenerator;

        [TestInitialize]
        public void Initialize()
        {
            _primeNumGenerator = new PrimeNumberGenerator();
        }

        [TestMethod]
        public void HappyPath_PreprocessPrimes()
        {
            var preProcessedPrimes = _primeNumGenerator.PreprocessPrimes(28);

            Assert.AreEqual(3, preProcessedPrimes.Count);

            Assert.AreEqual(2, preProcessedPrimes[0]);
            Assert.AreEqual(3, preProcessedPrimes[1]);
            Assert.AreEqual(5, preProcessedPrimes[2]);
        }

        [TestMethod]
        public void Negative_PreprocessPrimes_Zero()
        {
            var preProcessedPrimes = _primeNumGenerator.PreprocessPrimes(0);

            Assert.AreEqual(0, preProcessedPrimes.Count);
        }

        [TestMethod]
        public void Negative_PreprocessPrimes_One()
        {
            var preprocessedPrimes = _primeNumGenerator.PreprocessPrimes(1);

            Assert.AreEqual(0, preprocessedPrimes.Count);
        }

        [TestMethod]
        public void Negative_PreprocessPrimes_Two()
        {
            var preProcessedPrimes = _primeNumGenerator.PreprocessPrimes(2);

            Assert.AreEqual(0, preProcessedPrimes.Count);
        }

        [TestMethod]
        public void HappyPath_PreprocessPrimes_Three()
        {
            var preProcessedPrimes = _primeNumGenerator.PreprocessPrimes(3);

            Assert.AreEqual(1, preProcessedPrimes.Count);

            Assert.AreEqual(2, preProcessedPrimes[0]);
        }
    }
}
