package com.png.implementations.tests;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.*;

import com.png.implementations.PrimeNumberGenerator;
import com.png.interfaces.*;

class isPrimeTests {
	IPrimeNumberGenerator primeNumberGenerator;
	
	@BeforeEach
	void init() {
		primeNumberGenerator = new PrimeNumberGenerator();
	}
	
	@Test
	void happyPath_EvenPrimeNumber_Two() {
		boolean isPrime = primeNumberGenerator.isPrime(2);
		
		assertTrue(isPrime);
	}

	@Test
	void happyPath_OddPrimeNumber_Three() {
		boolean isPrime = primeNumberGenerator.isPrime(3);
		
		assertTrue(isPrime);
	}
	
	@Test
	void happyPath_PrimeNumber_7901() {
		boolean isPrime = primeNumberGenerator.isPrime(7901);
		
		assertTrue(isPrime);
	}
	
	@Test
	void negative_EvenCompositeNumber_Four() {
		boolean isPrime = primeNumberGenerator.isPrime(4);
		
		assertFalse(isPrime);
	}
	
	@Test
	void negative_OddCompositeNumber_21() {
		boolean isPrime = primeNumberGenerator.isPrime(21);
		
		assertFalse(isPrime);
	}
	
	@Test
	void happyPath_PrimeNumber_23() {
		boolean isPrime = primeNumberGenerator.isPrime(23);
		
		assertTrue(isPrime);
	}
	
	@Test
	void negative_OddCompositeNumber_121() {
		boolean isPrime = primeNumberGenerator.isPrime(121);
		
		assertFalse(isPrime);
	}
	
	@Test
	void happyPath_PrimeNumber_631() {
		boolean isPrime = primeNumberGenerator.isPrime(631);
		
		assertTrue(isPrime);
	}
	
	@Test
	void negative_EvenCompositeNumber_7900() {
		boolean isPrime = primeNumberGenerator.isPrime(7900);
		
		assertFalse(isPrime);
	}
	
	@Test
	void happyPath_PrimeNumber_7919() {
		boolean isPrime = primeNumberGenerator.isPrime(7919);
		
		assertTrue(isPrime);
	}
	
	@Test
	void happyPath_OddPrimeNumber_MaxIntValue() {
		boolean isPrime = primeNumberGenerator.isPrime(Integer.MAX_VALUE);
		
		assertTrue(isPrime);
	}
	
	@Test
	void negative_NotPrime_NegativeNumber() {
		boolean isPrime = primeNumberGenerator.isPrime(-4);
		
		assertFalse(isPrime);
	}
	
	@Test
	void negative_NotPrime_Zero() {
		boolean isPrime = primeNumberGenerator.isPrime(0);
		
		assertFalse(isPrime);
	}
	
	@Test
	void negative_NotPrime_One() {
		boolean isPrime = primeNumberGenerator.isPrime(1);
		
		assertFalse(isPrime);
	}
}
