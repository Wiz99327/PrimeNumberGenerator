package com.png.interfaces;
import java.util.List;

public interface IPrimeNumberGenerator {
	List<Integer> generate(int startValue, int endValue);
	boolean isPrime(int value);
}
