using System;
 class Program
 {
     // name age and gender
     public string name;
     public int age;
     public string gender;
     // constructor
     Program(string name, int age, string gender)
     {
         this.name = name;
         this.age = age;
         this.gender = gender;
     }
     public void show()
     {
         Console.WriteLine("Name: " + name);
         Console.WriteLine("Age: " + age);
         Console.WriteLine("Gender: " + gender);
     }
 
     static void Main()
     {
         Program p = new Program("Sohan", 22, "Male");
         p.show();
         Program v = new Program("Samip", 22, "Male");
         v.show();
     }
 
 }