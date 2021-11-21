using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using PrimeNumberGeneratorExercise.Interfaces;

[assembly:InternalsVisibleTo("PrimeNumberGeneratorTests")]
namespace PrimeNumberGeneratorExercise.BusinessLogic
{
    public sealed class PrimeNumberGenerator : IPrimeNumberGenerator
    {
        public List<int> Generate(int startingValue, int endingValue)
        {
            var primeNumbers = new List<int>();

            // We can't have any values less than zero, so return an empty list here
            if (startingValue < 0 || endingValue < 0)
            {
                return primeNumbers;
            }

            // Since the inputs allow for any order of values, we'll
            // need to get the lower value and higher value so that
            // all prime numbers can be returned in ascending order
            int trueStart = Math.Min(startingValue, endingValue);
            int trueEnd = Math.Max(startingValue, endingValue);

            
            // Return any preprocessed prime numbers here to help us
            // with larger numbers and determining their prime/composite status
            var preProcessedPrimes = PreprocessPrimes(trueEnd);

            // If our specified range falls in the range of the already preprocessed
            // prime numbers, add them to our list
            primeNumbers.AddRange(preProcessedPrimes.Where(x => x >= trueStart));

            // If we have any preprocessed prime numbers, start at the maximum preprocessed prime + 1
            // if we have preprocessed prime numbers that fell within the passed in range.
            // Otherwise, start at the provided startValue (either because our start value is really
            // low, so we didn't preprocess anything or because our start value is higher than
            // the highest prime we preprocessed
            int start = primeNumbers.Count > 0 ? primeNumbers.Max() + 1 : trueStart;
            for (int i = start; i <= trueEnd; i++)
            {
                // Check if our number is prime and if it is, add it to our final list
                if (IsPrime(i, preProcessedPrimes))
                {
                    primeNumbers.Add(i);
                }
            }

            return primeNumbers;
        }

        /// <summary>
        /// The standalone call to determine if a specific value is prime
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsPrime(int value)
        {
            return IsPrime(value, PreprocessPrimes(value));
        }

        private bool IsPrime(int value, IEnumerable<int> preProcessedPrimes)
        {
            // 0 and 1 are not prime and, for this exercise, only positive integers can be evaluated.
            // Otherwise, iterate through the prime numbers we've already preprocessed
            // and determine if any of them divide evenly (remainder/modulus is 0).
            // The first number that does this confirms the passed in value is
            // composite, so we'll return from this method here
            if (value <= 1
                || preProcessedPrimes.FirstOrDefault(x => value % x == 0) > 0)
            {
                return false;
            }

            // If we get down here, we can say with high confidence that
            // the passed in value is a prime number
            return true;
        }

        /// <summary>
        /// Returns a small subset of prime numbers that we can use during
        /// the rest of the generation process for dividing larger numbers,
        /// which will tell us if a specific number is prime
        /// </summary>
        /// <param name="endValue">The highest value to determine if it is prime</param>
        /// <returns></returns>
        internal List<int> PreprocessPrimes(int endValue)
        {
            if (endValue < 0)
            {
                return null;
            }

            var primes = new List<int>();

            // The highest value that we're initially concerned about is the
            // square root of the last value to check for being prime. The reason
            // for this is because a higher value won't matter for division, since
            // this can be accomplished by a lower (and prime) number. We'll use
            // this value as our max for the initial prime list
            var maxFactor = Convert.ToInt32(Math.Sqrt(endValue));

            // We can start at 2 because this is the first prime number
            for (int i = 2; i <= maxFactor; i++)
            {
                // Check if any of the prime numbers in our list evenly
                // divide into the current, iterated value. If it does,
                // the iterative value is not prime and will return the first
                // number that meets the below condition. If a zero is returned
                // (none of the prime numbers in our list are evenly divided by the iterator),
                // this number is prime and we'll add it to our preprocessed list
                if (!primes.Any(x => i % x == 0))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }
    }
}
