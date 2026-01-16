using System;

class Program
{
    static void Main(string[] args)
    {
        //get username
        DisplayWelcome();
        string userName = PromptUserName();

        //get user's favorite number
        int favNum = PromptUserNumber();

        //Get birth year from user
        int birhtYear;
        PromptUserBirthYear(out birhtYear);

        //Square users favorit number
        int squareNum = SquareNumber(favNum);

        //display final results
        DisplayResult(userName, squareNum, birhtYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        //Get username from user
        Console.Write("What is your Username? ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {   
        //Get favorite number from user and return it
        Console.Write("What is your favorite number? ");
        int num = int.Parse(Console.ReadLine());

        return num;
    }
    static void PromptUserBirthYear(out int birthyear)
    {
        //Get birth year from user
        Console.Write("What is your birth year?");
        birthyear = int.Parse(Console.ReadLine());
    }

    static int SquareNumber(int number)
    {
        int squared = number * number;

        return squared;
    }

    static void DisplayResult(String userName, int squareNum, int birhtYear)
    {
        //Display name and the square of users favorite number
        Console.WriteLine($"{userName} the square of your number is {squareNum}.");

        //get current year
        int year = DateTime.Now.Year;

        //Tell user how old they will turn this year
        Console.WriteLine($"{userName} You will be {year - birhtYear} this year");
    }
}