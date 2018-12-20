package com.png.util;

public class InputValidation {
	int startValue = 0;
	int endValue = 0;

	public boolean validateInputParameters(String[] args) {
		boolean isValid = true;

		// The user can pass in two (and only two) numbers
		if (args.length != 2) {
			System.out.println("Please specify 2 integers");
			isValid = false;
		} else {
			// The user must pass in values that are considered
			// integers
			try {
				startValue = Integer.parseInt(args[0]);
				endValue = Integer.parseInt(args[1]);
			} catch (NumberFormatException ex) {
				System.out.println("One or more inputs is invalid");
				isValid = false;
			}
		}

		if (!isValid) {
			// A friendly reminder to the user of the appropriate
			// usage of this program
			displayUsage();
		}

		return isValid;
	}

	public int getStartValue() {
		return startValue;
	}

	public int getEndValue() {
		return endValue;
	}

	private static void displayUsage() {
		System.out.println("Usage: java com.png.PrimeNumberGeneratorExec <start value> <end value>");
		System.out.println("<start value> and <end value> must be valid integers");
	}
}
