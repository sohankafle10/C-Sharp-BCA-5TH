using System;

class MultiplyExample
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int result = num1 * num2;

        Console.WriteLine($"The result of multiplying {num1} and {num2} is: {result}");
    }
}