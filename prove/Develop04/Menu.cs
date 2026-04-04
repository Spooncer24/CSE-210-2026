using System.Runtime.CompilerServices;

class Menu
{
    public void Display()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Listening Activity");
        Console.WriteLine("3. Reflection Activity");
        Console.WriteLine("4. Quit");
    }

    public string GetChoice()
    {
        //Get choice of what user wants to do 
        Console.Write("What would you like to do? ");
        string choice = Console.ReadLine().ToLower();

        return choice;
    }
}