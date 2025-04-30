using System;wueue
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Queue<string> q1 = new Queue<string>();
        q1.Enqueue("BCA");
        q1.Enqueue("BIM");
        q1.Enqueue("BHM");
        q1.Enqueue("BBA");
        q1.Enqueue("BBS");

        Console.WriteLine("Elements in queue are:");
        foreach (string item in q1)
        {
            Console.WriteLine(item);
        }
    q1.Dequeue();
    q1.Dequeue();
        Console.WriteLine("After Removal:");
        foreach (string s in q1)
        {
            Console.WriteLine(s);
        }
    }
}

