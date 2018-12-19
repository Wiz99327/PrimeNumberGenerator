using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumberGeneratorExercise.BusinessLogic;
using PrimeNumberGeneratorExercise.Interfaces;

namespace PrimeNumberGeneratorTests
{
    [TestClass]
    public class IsPrimeTests
    {
        IPrimeNumberGenerator _primeNumGenerator;

        [TestInitialize]
        public void Initialize()
        {
            _primeNumGenerator = new PrimeNumberGenerator();
        }

        [TestMethod]
        public void HappyPath_EvenPrimeNumber_Two()
        {
            bool isPrime = _primeNumGenerator.IsPrime(2);

            Assert.IsTrue(isPrime);
        }

        [TestMethod]
        public void HappyPath_OddPrimeNumber_Three()
        {
            bool isPrime = _primeNumGenerator.IsPrime(3);

            Assert.IsTrue(isPrime);
        }

        [TestMethod]
        public void HappyPath_PrimeNumber_23()
        {
            bool isPrime = _primeNumGenerator.IsPrime(23);

            Assert.IsTrue(isPrime);
        }

        [TestMethod]
        public void HappyPath_PrimeNumber_7901()
        {
            bool isPrime = _primeNumGenerator.IsPrime(7901);

            Assert.IsTrue(isPrime);
        }

        [TestMethod]
        public void Negative_EvenCompositeNumber_Four()
        {
            bool isPrime = _primeNumGenerator.IsPrime(4);

            Assert.IsFalse(isPrime);
        }

        [TestMethod]
        public void Negative_OddCompositeNumber_21()
        {
            bool isPrime = _primeNumGenerator.IsPrime(21);

            Assert.IsFalse(isPrime);
        }

        [TestMethod]
        public void Negative_OddCompositeNumber_121()
        {
            bool isPrime = _primeNumGenerator.IsPrime(121);

            Assert.IsFalse(isPrime);
        }

        [TestMethod]
        public void HappyPath_PrimeNumber_631()
        {
            bool isPrime = _primeNumGenerator.IsPrime(631);

            Assert.IsTrue(isPrime);
        }

        [TestMethod]
        public void Negative_EvenCompositeNumber_7900()
        {
            bool isPrime = _primeNumGenerator.IsPrime(7900);

            Assert.IsFalse(isPrime);
        }

        [TestMethod]
        public void HappyPath_PrimeNumber_7919()
        {
            bool isPrime = _primeNumGenerator.IsPrime(7919);

            Assert.IsTrue(isPrime);
        }

        [TestMethod]
        public void HappyPath_OddPrimeNumber_MaxIntValue()
        {
            bool isPrime = _primeNumGenerator.IsPrime(int.MaxValue);

            Assert.IsTrue(isPrime);
        }

        [TestMethod]
        public void Negative_NotPrime_NegativeNumber()
        {
            bool isPrime = _primeNumGenerator.IsPrime(-4);

            Assert.IsFalse(isPrime);
        }

        [TestMethod]
        public void Negative_NotPrime_Zero()
        {
            bool isPrime = _primeNumGenerator.IsPrime(0);

            Assert.IsFalse(isPrime);
        }

        [TestMethod]
        public void Negative_NotPrime_One()
        {
            bool isPrime = _primeNumGenerator.IsPrime(1);

            Assert.IsFalse(isPrime);
        }
    }
}
