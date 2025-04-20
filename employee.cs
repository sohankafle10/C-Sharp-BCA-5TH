
//create a class called employee that inherits from person and adds as a method employee_details then,
 // create another class called manager that inherits from employee and adds a method department

using System;

public class Person
{
    private string name;
    private int age;

    public void SetName(string n)
    {
        name = n;
    }

    public void SetAge(int a)
    {
        age = a;
    }

    public string GetName()
    {
        return name;
    }

    public int GetAge()
    {
        return age;
    }
}

public class Employee : Person
{
    private string position;

    public void SetPosition(string p)
    {
        position = p;
    }

    public string GetPosition()
    {
        return position;
    }

    public void EmployeeDetails()
    {
        Console.WriteLine("Employee Name: " + GetName());
        Console.WriteLine("Age: " + GetAge());
        Console.WriteLine("Position: " + GetPosition());
    }
}

public class Manager : Employee
{
    private string dept;

    public void SetDepartment(string d)
    {
        dept = d;
    }

    public string GetDepartment()
    {
        return dept;
    }

    public void Department()
    {
        Console.WriteLine("Department: " + GetDepartment());
    }
}

class Program
{
    static void Main()
    {
        Manager m = new Manager();
        m.SetName("Sohan Kafle");
        m.SetAge(30);
        m.SetPosition("Project Manager");
        m.SetDepartment("Software Development");

        m.EmployeeDetails();
        m.Department();
    }
}
