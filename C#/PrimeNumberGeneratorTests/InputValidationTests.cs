using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumberGeneratorExercise.Helpers;

namespace PrimeNumberGeneratorTests
{
    [TestClass]
    public class InputValidationTests
    {
        InputValidation validation;

        [TestInitialize]
        public void Initialize()
        {
            validation = new InputValidation();
        }

        [TestMethod]
        public void HappyPath_InputsSuccessfullyValidated()
        {
            var isValid = validation.ValidateInputParameters(new[] { "1", "10" });

            Assert.IsTrue(isValid);

            Assert.AreEqual(1, validation.StartValue);
            Assert.AreEqual(10, validation.EndValue);
        }

        [TestMethod]
        public void HappyPath_InputsDescendingOrder_Valid()
        {
            var isValid = validation.ValidateInputParameters(new[] { "10", "1" });

            Assert.IsTrue(isValid);

            Assert.AreEqual(10, validation.StartValue);
            Assert.AreEqual(1, validation.EndValue);
        }

        [TestMethod]
        public void HappyPath_NegativeIntegerInputs_Valid()
        {
            var isValid = validation.ValidateInputParameters(new[] { "-2", "-3" });

            Assert.IsTrue(isValid);

            Assert.AreEqual(-2, validation.StartValue);
            Assert.AreEqual(-3, validation.EndValue);
        }

        [TestMethod]
        public void Negative_NotEnoughArguments()
        {
            var isValid = validation.ValidateInputParameters(new[] { "1" });

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void Negative_TooManyArguments()
        {
            var isValid = validation.ValidateInputParameters(new[] { "1", "2", "3" });

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void Negative_StartValueNotInteger()
        {
            var isValid = validation.ValidateInputParameters(new[] { "one", "5" });

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void Negative_EndValueNotInteger()
        {
            var isValid = validation.ValidateInputParameters(new[] { "1", "five" });

            Assert.IsFalse(isValid);
        }

        [TestMethod]
        public void Negative_BothValuesNotIntegers()
        {
            var isValid = validation.ValidateInputParameters(new[] { "one", "five" });

            Assert.IsFalse(isValid);
        }
    }
}
