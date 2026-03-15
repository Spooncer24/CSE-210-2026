using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment _assignment = new Assignment("Jimmy", "Art");

        Console.WriteLine(_assignment.GetSummery());
    }
}