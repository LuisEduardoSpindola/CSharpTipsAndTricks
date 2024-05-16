using System;

namespace TipsAndTricks;

class Program
{
    static void Main(string[] args)
    {
        // Example of the Ternary Conditional Operator in C#
        // The ternary conditional operator works like a default conditional statement (if/else),
        // but allows us to perform the operation in a single line of code.

        string weather = "Rainy"; // Define the weather condition
            
        // Use the ternary operator to determine the weather state
        var weatherState = weather == "Sunny" ? "Go to the Beach" : "Go and code something";
        Console.WriteLine(weatherState); // Output the result

        // Non-optimal example using if/else statement:
        // This example shows a traditional way to achieve the same logic with more lines of code.

        if (weather == "Clear")
        {
            Console.WriteLine("Go to the mall...");
        }
        else
        {
            Console.WriteLine("Keep and read something");
        }
        
        
        // More tips and tricks coming soon ...
    }
}