using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PrimeNumberGeneratorExercise;

namespace PrimeNumberGeneratorTests
{
    [TestClass]
    public class MainProgramTests
    {
        const string USAGE = "Usage: PrimeNumberGenerator.exe <start value> <end value>\r\n<start value> and <end value> must be valid integers\r\n";

        [TestMethod]
        public void HappyPath_PrimeNumbersExistInRange()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Program.Main(new[] { "1", "10" });

            Assert.IsNotNull(sw);
            Assert.AreEqual($"Prime numbers in specified range [1, 10] (in ascending order):{Environment.NewLine}2 3 5 7 {Environment.NewLine}", sw.ToString());
        }

        [TestMethod]
        public void HappyPath_PrimeNumbersExistInRange_ReverseParameters()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Program.Main(new[] { "10", "1" });

            Assert.IsNotNull(sw);
            Assert.AreEqual($"Prime numbers in specified range [10, 1] (in ascending order):{Environment.NewLine}2 3 5 7 {Environment.NewLine}", sw.ToString());
        }

        [TestMethod]
        public void Negative_PrimeNumbersDoNotExistInRange()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Program.Main(new[] { "8", "10" });

            Assert.IsNotNull(sw);
            Assert.AreEqual($"No prime numbers exist in specified range [8, 10]{Environment.NewLine}", sw.ToString());
        }

        [TestMethod]
        public void Negative_PrimeNumbersDoNotExistInRange_ReverseParameters()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Program.Main(new[] { "10", "8" });

            Assert.IsNotNull(sw);
            Assert.AreEqual($"No prime numbers exist in specified range [10, 8]{Environment.NewLine}", sw.ToString());
        }

        [TestMethod]
        public void Negative_NegativeNumbersEntered()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Program.Main(new[] { "-1", "-5" });

            Assert.IsNotNull(sw);
            Assert.AreEqual($"No prime numbers exist in specified range [-1, -5]{Environment.NewLine}", sw.ToString());
        }

        [TestMethod]
        public void Negative_InvalidInteger_StartValue()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Program.Main(new[] { "abc", "5" });

            Assert.IsNotNull(sw);
            Assert.AreEqual($"One or more values is invalid{Environment.NewLine}{USAGE}", sw.ToString());
        }

        [TestMethod]
        public void Negative_InvalidInteger_EndValue()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Program.Main(new[] { "1", "abc" });

            Assert.IsNotNull(sw);
            Assert.AreEqual($"One or more values is invalid{Environment.NewLine}{USAGE}", sw.ToString());
        }

        [TestMethod]
        public void Negative_InvalidIntegers_BothValues()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Program.Main(new[] { "abc", "def" });

            Assert.IsNotNull(sw);
            Assert.AreEqual($"One or more values is invalid{Environment.NewLine}{USAGE}", sw.ToString());
        }

        [TestMethod]
        public void Negative_NotEnoughParameters()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Program.Main(new[] { "1" });

            Assert.IsNotNull(sw);
            Assert.AreEqual($"Please specify 2 integers{Environment.NewLine}{USAGE}", sw.ToString());
        }

        [TestMethod]
        public void Negative_TooManyParameters()
        {
            StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            Program.Main(new[] { "1", "2", "3" });

            Assert.IsNotNull(sw);
            Assert.AreEqual($"Please specify 2 integers{Environment.NewLine}{USAGE}", sw.ToString());
        }
    }
}
