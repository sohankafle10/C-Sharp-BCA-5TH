using System;

class ExceptionDemo
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered: {number}");
        }
        catch (FormatException )
        {
            Console.WriteLine("Error: Please enter a valid number.");
            Console.WriteLine("Exception Details: {ex.Message}");
        }
        catch (Exception )
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine("Exception Details: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Execution completed.");
            //   Console.WriteLine("Execution completed.");
        }
    }
}