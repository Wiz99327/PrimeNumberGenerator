package com.png;

import java.util.*;

import com.png.implementations.PrimeNumberGenerator;
import com.png.interfaces.*;
import com.png.util.InputValidation;

public class PrimeNumberGeneratorExec {

	public static void main(String[] args) {
		InputValidation validation = new InputValidation();
		
		if (validation.validateInputParameters(args)) {
			int startValue = validation.getStartValue();
			int endValue = validation.getEndValue();
			
			IPrimeNumberGenerator primeNumberGenerator = new PrimeNumberGenerator();
			
			List<Integer> primeNumbers = primeNumberGenerator.generate(startValue, endValue);
			
			if (primeNumbers == null || primeNumbers.isEmpty()) {
				System.out.print("No prime numbers exist in specified range");
				printNumberRange(startValue, endValue);
				System.out.println();
				return;
			}
			
			System.out.print("List of prime numbers in specified range");
			printNumberRange(startValue, endValue);
			System.out.println(":");
			
			for (int i = 0; i < primeNumbers.size(); i++) {
				System.out.print(primeNumbers.get(i));
				System.out.print(" ");
			}
		}
	}

	private static void printNumberRange(int startValue, int endValue) {
		System.out.print(" [");
		System.out.print(startValue);
		System.out.print(", ");
		System.out.print(endValue);
		System.out.print("]");
	}
}
