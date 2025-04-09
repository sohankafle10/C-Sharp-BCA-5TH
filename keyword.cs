using System;
class Student
{
    public int id, age;
    public String name, subject;
    public Student(int id, string name, int age, String subject)
    {
        this.id = id;
        this.name = name;
        this.subject = subject;
        this.age = age;
    }
    public void showInfo()
    {
        Console.WriteLine(id + " " + name + " " + age + " " + subject);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(1, "Sohan", 22, "C#");
        s1.showInfo();
        Student s2 = new Student(2, "Samip", 22, "C#");
        s2.showInfo();
}
}