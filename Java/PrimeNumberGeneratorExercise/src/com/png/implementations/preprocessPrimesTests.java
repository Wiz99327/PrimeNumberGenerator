package com.png.implementations;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;
import org.junit.jupiter.api.*;
import java.util.*;

class preprocessPrimesTests {
	PrimeNumberGenerator primeNumberGenerator;
	
	@BeforeEach
	void init() {
		primeNumberGenerator = new PrimeNumberGenerator();
	}
	
	@Test
	void happyPath_PreprocessPrimes() {
		List<Integer> preprocessedPrimes = primeNumberGenerator.preprocessPrimes(28);
		
		assertEquals(3, preprocessedPrimes.size());
		
		assertEquals(2, preprocessedPrimes.get(0).intValue());
		assertEquals(3, preprocessedPrimes.get(1).intValue());
		assertEquals(5, preprocessedPrimes.get(2).intValue());
	}

	@Test
	void negative_PreprocessPrimes_Zero() {
		List<Integer> preprocessedPrimes = primeNumberGenerator.preprocessPrimes(0);
		
		assertEquals(0, preprocessedPrimes.size());
	}
	
	@Test
	void negative_PreprocessPrimes_One() {
		List<Integer> preprocessedPrimes = primeNumberGenerator.preprocessPrimes(1);
		
		assertEquals(0, preprocessedPrimes.size());
	}
	
	@Test
	void negative_PreprocessPrimes_Two() {
		List<Integer> preprocessedPrimes = primeNumberGenerator.preprocessPrimes(2);
		
		assertEquals(0, preprocessedPrimes.size());
	}
	
	@Test
	void happyPath_PreprocessPrimes_Three() {
		List<Integer> preprocessedPrimes = primeNumberGenerator.preprocessPrimes(3);
		
		assertEquals(1, preprocessedPrimes.size());
		
		assertEquals(2, preprocessedPrimes.get(0).intValue());
	}
}
