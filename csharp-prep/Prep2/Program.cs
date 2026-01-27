using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Get grade percent from user
        Console.Write("What grade percentage did you get? ");
        int percent = int.Parse(Console.ReadLine());

        //Setting up variables
        string grade = "";

        //convert grade percent to letter grade
        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else 
        {
            grade = "F";
        }

        Console.WriteLine ($"Your grade is {grade}");

        //Determine if percent is a pass or fail
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations you passed!!!!!");
        }
        else
        {
            Console.WriteLine("You did not pass, better luck next time!");
        }



        


    }
}