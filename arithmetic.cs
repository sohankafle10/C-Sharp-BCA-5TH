// write a program for the implemantation of arithmetic operation using two values from user.


using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int sum = number1 + number2;
        int sub = number1 - number2;
        int mul = number1 * number2;
        int div = number1 / number2;

        Console.WriteLine("The sum of the two numbers is: " + sum);
        Console.WriteLine("The sub of the two numbers is: " + sub);
        Console.WriteLine("The mul of the two numbers is: " + mul);
        Console.WriteLine("The div of the two numbers is: " + div);
    }
}
