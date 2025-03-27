using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        Console.WriteLine("Enter the numbers:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        Console.WriteLine("Numbers in ascending order:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}