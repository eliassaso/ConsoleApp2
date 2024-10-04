using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");

        try
        {
            // This line tries to read input and convert it to an integer
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput); // This can throw a FormatException if the input is not a valid number

            Console.WriteLine($"You entered the number: {number}");
        }
        catch (FormatException ex)
        {
            // This block will run if a FormatException occurs (e.g., when input is not a number) data abc
            Console.WriteLine("Error: Please enter a valid number.");
            Console.WriteLine($"Technical details: {ex.Message}");
        }
        catch (Exception ex)
        {
            // This block catches any other exceptions that may happen data 3000000000
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine($"Technical details: {ex.Message}");
        }
        finally
        {
            // This block always runs, no matter what (even if there's no error)
            Console.WriteLine("Program has finished running.");
        }
    }
}