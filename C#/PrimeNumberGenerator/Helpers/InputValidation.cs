using System;

namespace PrimeNumberGeneratorExercise.Helpers
{
    /// <summary>
    /// Responsible for validating the provided input arguments
    /// and taking appropriate action if there is a problem
    /// </summary>
    internal class InputValidation
    {
        public bool ValidateInputParameters(string[] args)
        {
            int startValue = 0;
            int endValue = 0;

            bool isValid = true;

            // The user can pass in two (and only two) numbers
            if (args.Length != 2)
            {
                Console.WriteLine("Please specify 2 integers");
                isValid = false;
            }
            else if (!int.TryParse(args[0], out startValue)
                || !int.TryParse(args[1], out endValue))
            {
                // The user must pass in values that are considered
                // integers
                Console.WriteLine("One or more values is invalid");
                isValid = false;
            }

            if (!isValid)
            {
                // A friendly reminder to the user of the appropriate
                // usage of this program
                DisplayUsage();
            }

            StartValue = startValue;
            EndValue = endValue;

            return isValid;
        }

        private static void DisplayUsage()
        {
            Console.WriteLine("Usage: PrimeNumberGenerator.exe <start value> <end value>");
            Console.WriteLine("<start value> and <end value> must be valid integers");
        }

        public int StartValue { get; private set; }
        public int EndValue { get; private set; }
    }
}
