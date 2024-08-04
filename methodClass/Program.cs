using System;

namespace ConsoleApp
{
    // Define a class named 'MathOperations'
    class MathOperations
    {
        // Define a method that takes two integers and performs a math operation
        public void PerformOperation(int num1, int num2)
        {
            // Perform addition operation on the first integer
            int result = num1 + 10;

            // Display the result of the operation
            Console.WriteLine("Result of the operation on the first integer: " + result);

            // Display the second integer
            Console.WriteLine("Second integer: " + num2);
        }
    }
    class Program
    {
        // Main method - entry point of the console application
        static void Main(string[] args)
        {
            // Instantiate the 'MathOperations' class
            MathOperations mathOperations = new MathOperations();

            // Call the 'PerformOperation' method with two integers
            mathOperations.PerformOperation(5, 20);

            // Call the 'PerformOperation' method with named parameters
            mathOperations.PerformOperation(num1: 15, num2: 30);

            // Wait for user input to close the console window
            Console.ReadLine();
        }
    }
}