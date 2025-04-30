using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Stack<string> s1 = new Stack<string>();
        s1.Push("BCA");
        s1.Push("BIM");
        s1.Push("BHM");
        s1.Push("BBA");
        s1.Push("BBS");

        Console.WriteLine("Elements in stack are:");
        foreach (string item in s1)
        {
            Console.WriteLine(item);
        }
        s1.Pop();
        s1.Pop();
        Console.WriteLine("After Removal:");
        foreach (string s in s1)
        {
            Console.WriteLine(s);
        }
    }
}