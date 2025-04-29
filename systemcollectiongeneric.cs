// System.Collections.Generic

using System;
using System.Collections.Generic;
class Test<T>
{
    T[] items = new T[5];
    int count = 0;
    public void addItem(T item)
    {
        if (count < 5)
        {
            items[count] = item;
            count++;
        }
        else
        {
            Console.WriteLine("Overhead exists");
        }
    }
    public void display()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Index " + i + " : " + items[i]);
        }
    }
}
class Program
{
    static void Main()
    {
        Test<int> obj = new Test<int>();
        obj.addItem(10);
        obj.addItem(20);
        obj.addItem(30);
        obj.addItem(40);
        obj.display();
    }
}
