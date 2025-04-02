using System;
using  System.Collections.Generic;
class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        numbers.Add(101);
        numbers.Add(102);
        numbers.Add(103);

        foreach (int num in numbers)
        {
            Console.WriteLine("Number: " + num);
        }
    }
}