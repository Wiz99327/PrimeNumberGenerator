using System.Collections.Generic;

namespace PrimeNumberGeneratorExercise.Interfaces
{
    public interface IPrimeNumberGenerator
    {
        List<int> Generate(int startingValue, int endingValue);
        bool IsPrime(int value);
    }
}
