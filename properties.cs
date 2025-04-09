using System;

class Myclass
{
    private int x;

    public void Setx(int i)
    {
        x = i; 
    }

    public int Getx()
    {
        return x;
    }
}

class Program
{
    static void Main()
    {
        Myclass obj = new Myclass(); 
        obj.Setx(10); 
        int val = obj.Getx();
        Console.WriteLine("value: " + val); 
}
}