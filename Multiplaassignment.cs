// create a different classes named rose and lilly and add specific method relevant to that type of class. then create another class named flower that inherits from both rose and lilly. Show how to achieve it
using System;

// Define the Rose behavior using an interface
interface IRose
{
    string DescribeRose();
    string Smell();
}

// Define the Lilly behavior using an interface
interface ILilly
{
    string DescribeLilly();
    string BloomSeason();
}

// Flower class implementing both interfaces
class Flower : IRose, ILilly
{
    public string DescribeRose()
    {
        return "Rose is red and symbolizes love.";
    }

    public string Smell()
    {
        return "Rose has a sweet fragrance.";
    }

    public string DescribeLilly()
    {
        return "Lilly is white and symbolizes purity.";
    }

    public string BloomSeason()
    {
        return "Lilly blooms in summer.";
    }

    public string GeneralInfo()
    {
        return "Flower is a beautiful part of nature.";
    }
}

// Program to test the Flower class
class Program
{
    static void Main()
    {
        Flower myFlower = new Flower();

        Console.WriteLine(myFlower.DescribeRose());
        Console.WriteLine(myFlower.Smell());
        Console.WriteLine(myFlower.DescribeLilly());
        Console.WriteLine(myFlower.BloomSeason());
        Console.WriteLine(myFlower.GeneralInfo());
    }
}
