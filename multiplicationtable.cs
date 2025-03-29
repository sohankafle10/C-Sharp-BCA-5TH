using System;

class MultiplicationTable
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(" Multiplication Table of " + i);
            Console.WriteLine(new string('-', 20));
            
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine(" i x {j,-2} = {i * j,-3} |");
            }
            
            Console.WriteLine(new string('-', 20));
            Console.WriteLine(); // Blank line for separation
        }
    }
}
