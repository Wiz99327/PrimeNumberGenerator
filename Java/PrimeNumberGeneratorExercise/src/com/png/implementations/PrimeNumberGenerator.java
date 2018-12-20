package com.png.implementations;

import java.util.*;

import com.png.interfaces.IPrimeNumberGenerator;

public final class PrimeNumberGenerator implements IPrimeNumberGenerator {
	public List<Integer> generate(int startValue, int endValue)	{
		List<Integer> primeNumbers = new ArrayList<Integer>();
		
		// We can't have any values less than zero, so return an empty list here
		if (startValue < 0 || endValue < 0) {
			return primeNumbers;
		}

		// Since the inputs allow for any order of values, we'll
        // need to get the lower value and higher value so that
        // all prime numbers can be returned in ascending order
		int trueStart = Math.min(startValue, endValue);
		int trueEnd = Math.max(startValue, endValue);
		
		// Return any preprocessed prime numbers here to help us
        // with larger numbers and determining their prime/composite status
		List<Integer> preprocessedPrimes = preprocessPrimes(trueEnd);
		
		// If our specified range falls in the range of the already preprocessed
        // prime numbers, add them to our list
		for (int i = 0; i < preprocessedPrimes.size(); i++) {
			if (preprocessedPrimes.get(i) >= trueStart) {
				primeNumbers.addAll(preprocessedPrimes.subList(i, preprocessedPrimes.size()));
				break;
			}
		}
		
		// If we have any preprocessed prime numbers, start at the maximum preprocessed prime + 1
        // if we have preprocessed prime numbers that fell within the passed in range.
        // Otherwise, start at the provided startValue (either because our start value is really
        // low, so we didn't preprocess anything or because our start value is higher than
        // the highest prime we preprocessed
		int startIndex = primeNumbers.isEmpty() ? trueStart : primeNumbers.get(primeNumbers.size() - 1) + 1;
		for (int i = startIndex; i <= trueEnd; i++) {
			// Check if our number is prime and if it is, add it to our final list
			if (isPrime(i, preprocessedPrimes)) {
				primeNumbers.add(i);
			}
		}
		
		return primeNumbers;
	}
	
	public boolean isPrime(int value) {
		return isPrime(value, preprocessPrimes(value));
	}
	
	private boolean isPrime(int value, List<Integer> preprocessedPrimes) {
		// 0 and 1 are not prime and, for this exercise, only positive integers can be evaluated.
		if (value <= 1) {
			return false;
		}
		
        // Iterate through the prime numbers we've already preprocessed
        // and determine if any of them divide evenly (remainder is 0).
        // The first number that does this confirms the passed in value is
        // composite, so we'll return from this method here
		for (int i = 0; i < preprocessedPrimes.size(); i++) {
			if (value % preprocessedPrimes.get(i) == 0) {
				return false;
			}
		}
		
		// If we get down here, we can say with high confidence that
        // the passed in value is a prime number
		return true;
	}
	
	List<Integer> preprocessPrimes(int endValue) {
		if (endValue < 0) {
			return null;
		}
		
		List<Integer> primeFactors = new ArrayList<Integer>();
		
		// The highest value that we're initially concerned about is the
        // square root of the last value to check for being prime. The reason
        // for this is because a higher value won't matter for division, since
        // this can be accomplished by a lower (and prime) number. We'll use
        // this value as our max for the initial prime list
		int maxFactor = (int) Math.round(Math.sqrt(endValue));
		
		// We can start at 2 because this is the first prime number
		for (int i = 2; i <= maxFactor; i++) {
			boolean factorFound = false;
			
			// Check if any of the prime numbers in our list evenly
            // divide into the current, iterated value. If it does,
            // the iterative value is not prime and will return the first
            // number that meets the below condition. If a zero is returned
            // (none of the prime numbers in our list are evenly divided by the iterator),
            // this number is prime and we'll add it to our preprocessed list
			for (int j = 0; j < primeFactors.size(); j++) {
				if (i % primeFactors.get(j) == 0) {
					factorFound = true;
					break;
				}
			}
			
			if (!factorFound) {
				primeFactors.add(i);
			}
		}
		
		return primeFactors;
	}
}
