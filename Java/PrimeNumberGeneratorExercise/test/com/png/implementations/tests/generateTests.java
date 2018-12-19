package com.png.implementations.tests;

import static org.junit.jupiter.api.Assertions.*;

import java.util.*;

import org.junit.jupiter.api.*;

import com.png.implementations.PrimeNumberGenerator;
import com.png.interfaces.*;

class generateTests {
	IPrimeNumberGenerator primeNumberGenerator;
	
	@BeforeEach
	void init() {
		primeNumberGenerator = new PrimeNumberGenerator();
	}
	
	@Test
	void happyPath_First26Primes() {
		List<Integer> primeNumbers = primeNumberGenerator.generate(2, 101);
		
		assertEquals(26, primeNumbers.size());
		
		assertEquals(2, primeNumbers.get(0).intValue());
		assertEquals(3, primeNumbers.get(1).intValue());
		assertEquals(5, primeNumbers.get(2).intValue());
		assertEquals(7, primeNumbers.get(3).intValue());
		assertEquals(11, primeNumbers.get(4).intValue());
		assertEquals(13, primeNumbers.get(5).intValue());
		assertEquals(17, primeNumbers.get(6).intValue());
		assertEquals(19, primeNumbers.get(7).intValue());
		assertEquals(23, primeNumbers.get(8).intValue());
		assertEquals(29, primeNumbers.get(9).intValue());
		assertEquals(31, primeNumbers.get(10).intValue());
		assertEquals(37, primeNumbers.get(11).intValue());
		assertEquals(41, primeNumbers.get(12).intValue());
		assertEquals(43, primeNumbers.get(13).intValue());
		assertEquals(47, primeNumbers.get(14).intValue());
		assertEquals(53, primeNumbers.get(15).intValue());
		assertEquals(59, primeNumbers.get(16).intValue());
		assertEquals(61, primeNumbers.get(17).intValue());
		assertEquals(67, primeNumbers.get(18).intValue());
		assertEquals(71, primeNumbers.get(19).intValue());
		assertEquals(73, primeNumbers.get(20).intValue());
		assertEquals(79, primeNumbers.get(21).intValue());
		assertEquals(83, primeNumbers.get(22).intValue());
		assertEquals(89, primeNumbers.get(23).intValue());
		assertEquals(97, primeNumbers.get(24).intValue());
		assertEquals(101, primeNumbers.get(25).intValue());
	}

	@Test
	void happyPath_Numbers7900To7920() {
		List<Integer> primeNumbers = primeNumberGenerator.generate(7900, 7920);
		
		assertEquals(3, primeNumbers.size());
		
		assertEquals(7901, primeNumbers.get(0).intValue());
		assertEquals(7907, primeNumbers.get(1).intValue());
		assertEquals(7919, primeNumbers.get(2).intValue());
	}
	
	@Test
	void happyPath_FirstLessThanSecond() {
		List<Integer> primeNumbers = primeNumberGenerator.generate(1, 10);
		
		assertEquals(4, primeNumbers.size());
		
		assertEquals(2, primeNumbers.get(0).intValue());
		assertEquals(3, primeNumbers.get(1).intValue());
		assertEquals(5, primeNumbers.get(2).intValue());
		assertEquals(7, primeNumbers.get(3).intValue());
	}
	
	@Test
	void happyPath_SecondLessThanFirst() {
		List<Integer> primeNumbers = primeNumberGenerator.generate(10, 1);
		
		assertEquals(4, primeNumbers.size());
		
		assertEquals(2, primeNumbers.get(0).intValue());
		assertEquals(3, primeNumbers.get(1).intValue());
		assertEquals(5, primeNumbers.get(2).intValue());
		assertEquals(7, primeNumbers.get(3).intValue());
	}
	
	@Test
	void happyPath_BothInputsSamePrimeNumber() {
		List<Integer> primeNumbers = primeNumberGenerator.generate(5, 5);
		
		assertEquals(1, primeNumbers.size());
		
		assertEquals(5, primeNumbers.get(0).intValue());
	}
	
	@Test
	void happyPath_PrimeNumbersBetween4And37() {
		List<Integer> primeNumbers = primeNumberGenerator.generate(4, 37);
		
		assertEquals(10, primeNumbers.size());
		assertEquals(5, primeNumbers.get(0).intValue());
		assertEquals(7, primeNumbers.get(1).intValue());
		assertEquals(11, primeNumbers.get(2).intValue());
		assertEquals(13, primeNumbers.get(3).intValue());
		assertEquals(17, primeNumbers.get(4).intValue());
		assertEquals(19, primeNumbers.get(5).intValue());
		assertEquals(23, primeNumbers.get(6).intValue());
		assertEquals(29, primeNumbers.get(7).intValue());
		assertEquals(31, primeNumbers.get(8).intValue());
		assertEquals(37, primeNumbers.get(9).intValue());
	}
	
	@Test
	void negative_ZeroesEntered() {
		List<Integer> primeNumbers = primeNumberGenerator.generate(0, 0);
		
		assertEquals(0, primeNumbers.size());
	}
	
	@Test
	void negative_OnesEntered() {
		List<Integer> primeNumbers = primeNumberGenerator.generate(1, 1);
		
		assertEquals(0, primeNumbers.size());
	}
	
	@Test
	void negative_SameCompositeNumberEntered() {
		List<Integer> primeNumbers = primeNumberGenerator.generate(6, 6);
		
		assertEquals(0, primeNumbers.size());
	}
	
	@Test
	void negative_StartValue_NegativeNumberEntered() {
		List<Integer> primeNumbers = primeNumberGenerator.generate(-1, 3);
		
		assertEquals(0, primeNumbers.size());
	}
	
	@Test
	void negative_EndValue_NegativeNumberEntered() {
		List<Integer> primeNumbers = primeNumberGenerator.generate(5, -1);
		
		assertEquals(0, primeNumbers.size());
	}
	
	@Test
	void negative_StartEndValue_NegativeNumbersEntered() {
		List<Integer> primeNumbers = primeNumberGenerator.generate(-1, -5);
		
		assertEquals(0, primeNumbers.size());
	}
}
