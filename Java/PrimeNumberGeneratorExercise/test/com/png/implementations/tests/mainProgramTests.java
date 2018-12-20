package com.png.implementations.tests;
import java.io.*;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.*;

import com.png.*;

class mainProgramTests {
	static String USAGE = "Usage: PrimeNumberGenerator.exe <start value> <end value>\r\n<start value> and <end value> must be valid integers\r\n";
	
	@Test
	void happyPath_PrimeNumbersExistInRange() {
		OutputStream os = new ByteArrayOutputStream();
		PrintStream ps = new PrintStream(os);
		System.setOut(ps);
		
		PrimeNumberGeneratorExec.main(new String[] { "1", "10" });
		
		assertEquals("List of prime numbers in specified range [1, 10]:\r\n2 3 5 7 ", os.toString());
	}

	@Test
	void happyPath_PrimeNumbersExistInRange_ReverseParameters() {
		OutputStream os = new ByteArrayOutputStream();
		PrintStream ps = new PrintStream(os);
		System.setOut(ps);
		
		PrimeNumberGeneratorExec.main(new String[] { "10", "1" });
		
		assertEquals("List of prime numbers in specified range [10, 1]:\r\n2 3 5 7 ", os.toString());
	}
	
	@Test
	void negative_PrimeNumbersDoNotExistInRange() {
		OutputStream os = new ByteArrayOutputStream();
		PrintStream ps = new PrintStream(os);
		System.setOut(ps);
		
		PrimeNumberGeneratorExec.main(new String[] { "8", "10" });
		
		assertEquals("No prime numbers exist in specified range [8, 10]\r\n", os.toString());
	}
	
	@Test
	void negative_PrimeNumbersDoNotExistInRange_ReverseParameters() {
		OutputStream os = new ByteArrayOutputStream();
		PrintStream ps = new PrintStream(os);
		System.setOut(ps);
		
		PrimeNumberGeneratorExec.main(new String[] { "10", "8" });
		
		assertEquals("No prime numbers exist in specified range [10, 8]\r\n", os.toString());
	}
	
	@Test
	void negative_NegativeNumbersEntered() {
		OutputStream os = new ByteArrayOutputStream();
		PrintStream ps = new PrintStream(os);
		System.setOut(ps);
		
		PrimeNumberGeneratorExec.main(new String[] { "-1", "-5" });
		
		assertEquals("No prime numbers exist in specified range [-1, -5]\r\n", os.toString());
	}
	
	@Test
	void negative_InvalidInteger_StartValue() {
		OutputStream os = new ByteArrayOutputStream();
		PrintStream ps = new PrintStream(os);
		System.setOut(ps);
		
		PrimeNumberGeneratorExec.main(new String[] { "abc", "5" });
		
		assertEquals("One or more inputs is invalid\r\n" + USAGE, os.toString());
	}
	
	@Test
	void negative_InvalidInteger_EndValue() {
		OutputStream os = new ByteArrayOutputStream();
		PrintStream ps = new PrintStream(os);
		System.setOut(ps);
		
		PrimeNumberGeneratorExec.main(new String[] { "1", "abc" });
		
		assertEquals("One or more inputs is invalid\r\n" + USAGE, os.toString());
	}
	
	@Test
	void negative_InvalidIntegers_BothValues() {
		OutputStream os = new ByteArrayOutputStream();
		PrintStream ps = new PrintStream(os);
		System.setOut(ps);
		
		PrimeNumberGeneratorExec.main(new String[] { "abc", "def" });
		
		assertEquals("One or more inputs is invalid\r\n" + USAGE, os.toString());
	}
	
	@Test
	void negative_NotEnoughParameters() {
		OutputStream os = new ByteArrayOutputStream();
		PrintStream ps = new PrintStream(os);
		System.setOut(ps);
		
		PrimeNumberGeneratorExec.main(new String[] { "1" });
		
		assertEquals("Please specify 2 integers\r\n" + USAGE, os.toString());
	}
	
	@Test
	void negative_TooManyParameters() {
		OutputStream os = new ByteArrayOutputStream();
		PrintStream ps = new PrintStream(os);
		System.setOut(ps);
		
		PrimeNumberGeneratorExec.main(new String[] { "1", "2", "3" });
		
		assertEquals("Please specify 2 integers\r\n" + USAGE, os.toString());
	}
}
