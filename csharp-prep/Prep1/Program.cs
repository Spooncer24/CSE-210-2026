using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your First Name? ");
        string first_name = Console.ReadLine();

        Console.Write("What is your Last Name? ");
        string last_name = Console.ReadLine();

       Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}");
    }
}