package com.png.util.tests;

import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.*;

import com.png.util.*;

class inputValidationTests {
	InputValidation validation;
	
	@BeforeEach
	void init() {
		validation = new InputValidation();
	}
	
	@Test
	void happyPath_InputsSuccessfullyValidated() {
		boolean isValid = validation.validateInputParameters(new String[] { "1", "10" });
		
		assertTrue(isValid);
		
		assertEquals(1, validation.getStartValue());
		assertEquals(10, validation.getEndValue());
	}

	@Test
	void happyPath_InputsDescendingOrder_Valid() {
		boolean isValid = validation.validateInputParameters(new String[] { "10", "1" });
		
		assertTrue(isValid);
		
		assertEquals(10, validation.getStartValue());
		assertEquals(1, validation.getEndValue());
	}
	
	@Test
	void happyPath_NegativeIntegerInputs_Valid() {
		boolean isValid = validation.validateInputParameters(new String[] { "-2", "-3" });
		
		assertTrue(isValid);
		
		assertEquals(-2, validation.getStartValue());
		assertEquals(-3, validation.getEndValue());
	}
	
	@Test
	void negative_NotEnoughArguments() {
		boolean isValid = validation.validateInputParameters(new String[] { "1" });
		
		assertFalse(isValid);
	}
	
	@Test
	void negative_TooManyArguments() {
		boolean isValid = validation.validateInputParameters(new String[] { "1", "2", "3" });
		
		assertFalse(isValid);
	}
	
	@Test
	void negative_StartValueNotInteger() {
		boolean isValid = validation.validateInputParameters(new String[] { "one", "5" });
		
		assertFalse(isValid);
	}
	
	@Test
	void negative_EndValueNotInteger() {
		boolean isValid = validation.validateInputParameters(new String[] { "1", "five" });
		
		assertFalse(isValid);
	}
	
	@Test
	void negative_BothValuesNotIntegers() {
		boolean isValid = validation.validateInputParameters(new String[] { "one", "five" });
		
		assertFalse(isValid);
	}
}
