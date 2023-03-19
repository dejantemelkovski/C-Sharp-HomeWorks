using System;

using HomeWork05Part1.Classes;

class Program
{
    static void Main(string[] args)
    {
        Human human = new Human();

        Console.Write("Enter your first name: ");
        human.FirstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        human.LastName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age;
        if (int.TryParse(Console.ReadLine(), out age))
        {
            human.Age = age;
        }
        else
        {
            Console.WriteLine("Invalid age input.");
            return;
        }

        Console.WriteLine(human.GetPersonDetails());
    }
}