using System;
using System.Linq;
using PrimeNumberGeneratorExercise.BusinessLogic;
using PrimeNumberGeneratorExercise.Helpers;
using PrimeNumberGeneratorExercise.Interfaces;

namespace PrimeNumberGeneratorExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputValidation = new InputValidation();

            if (inputValidation.ValidateInputParameters(args))
            {
                IPrimeNumberGenerator primeNumGenerator = new PrimeNumberGenerator();
                
                var primeNumbers = primeNumGenerator.Generate(inputValidation.StartValue, inputValidation.EndValue);

                if (primeNumbers == null || !primeNumbers.Any())
                {
                    Console.WriteLine($"No prime numbers exist in specified range [{inputValidation.StartValue}, {inputValidation.EndValue}]");
                    return;
                }

                Console.WriteLine($"Prime numbers in specified range [{inputValidation.StartValue}, {inputValidation.EndValue}] (in ascending order):");

                foreach (var prime in primeNumbers)
                {
                    Console.Write($"{prime} ");
                }

                Console.WriteLine();
            }
        }
    }
}
