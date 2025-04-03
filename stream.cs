using System;
using System.IO;
 class Program
 {
    static void Main()
    {
        String path = "example.txt";
        File.WriteAllText(path, "Hello, World!");
        String contnt = File.ReadAllText(path);
        Console.WriteLine("Content of the file: " + contnt);
    }
 }

 