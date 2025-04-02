using System;
using System.Collections;
class Program{
    static void Main()
    {
        Hashtable students = new Hashtable();
        students.Add(101, "sohan");
         students.Add(102, "Samip");
          students.Add(103, "Bhugol");
           students.Add(104, 25);

           foreach(DictionaryEntry entry in students)
           {
            Console.WriteLine("key:" + entry.Key + " value:" + entry.Value);
           }
    }
}