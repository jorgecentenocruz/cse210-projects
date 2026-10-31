using System;

class Program
{
    static void Main(string[] args)
    {
        Welcome();

        string name = GetName();
        int number = GetNumber();

        ShowResult(name, Square(number));
    }

    static void Welcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string GetName()
    {
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }

    static int GetNumber()
    {
        Console.Write("Enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    static int Square(int number)
    {
        return number * number;
    }

    static void ShowResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}