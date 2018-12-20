# PrimeNumberGenerator
This repository contains my implementation of the PrimeNumberGenerator challenge in both C# and Java.  
Visual Studio was used to author the project in C#.  Eclipse was used to author the project in Java.  
Both projects may be opened and built in their respective IDEs and contain a main entry point for execution via a simple console app. Unit tests are included for each implmentation and cover all code paths.  
Once built, to execute the application, cd into the directory of the executable (or bin folder) and run the following commands:  
- C#: `PrimeNumberGenerator.exe <start value> <end value>`
- Java: `java com.png.PrimeNumberGeneratorExec <start value> <end value>`  

`<start value>` and `<end value>` must resolve to valid integers.  Invalid integers or the wrong number of parameters will return an error and display proper usage of the application.

For example, to run the C# implementation and to return the prime numbers in the range of `[1, 10]`, run the following command:  
`PrimeNumberGenerator.exe 1 10`  
and the expected result is:  
`Prime numbers in specified range [1, 10] (in ascending order):`  
`2 3 5 7`

NOTE: The parameters may be specified in any order, so `[1, 10]` and `[10, 1]` are equivalent and thus, will yield the same result.
