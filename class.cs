// create a base class vehicle and derive the classes car, truck and motorcycle from it. each derived classes should add specific method relevant to that type of vehicle

using System;

public class Vehicle
{
    public void StartEngine()
    {
        Console.WriteLine("Engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine("Engine stopped.");
    }
}

public class Car : Vehicle
{
    public void PlayMusic()
    {
        Console.WriteLine("Playing music in the car.");
    }
}

public class Truck : Vehicle
{
    public void LoadCargo()
    {
        Console.WriteLine("Loading cargo into the truck.");
    }
}

public class Motorcycle : Vehicle
{
    public void DoWheelie()
    {
        Console.WriteLine("Doing a wheelie on the motorcycle.");
    }
}

class Program
{
    static void Main()
    {
        // Car
        Car myCar = new Car();
        myCar.StartEngine();
        myCar.PlayMusic();
        myCar.StopEngine();

        Console.WriteLine();

        // Truck
        Truck myTruck = new Truck();
        myTruck.StartEngine();
        myTruck.LoadCargo();
        myTruck.StopEngine();

        Console.WriteLine();

        // Motorcycle
        Motorcycle myBike = new Motorcycle();
        myBike.StartEngine();
        myBike.DoWheelie();
        myBike.StopEngine();
    }
}
