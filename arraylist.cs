using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Create an ArrayList
        ArrayList arrayList = new ArrayList();

        // Add elements to the ArrayList
        arrayList.Add(1);
        arrayList.Add("Hello");
        arrayList.Add(3.14);
        arrayList.Add(true);

        // Display elements in the ArrayList
        Console.WriteLine("ArrayList elements:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Remove an element
        arrayList.Remove("Hello");

        // Display elements after removal
        Console.WriteLine("\nArrayList elements after removal:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        // Access an element by index
        Console.WriteLine("\nElement at index 1: {arrayList[1]}");

        // Insert an element at a specific index
        arrayList.Insert(1, "World");

        // Display elements after insertion
        Console.WriteLine("\nArrayList elements after insertion:");
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
    }
}