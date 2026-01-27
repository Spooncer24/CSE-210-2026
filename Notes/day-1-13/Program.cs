using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine ("hello chump"); //this writes a line and breaks it to the next line

        Console.Write ("Hello");           // This similar to WriteLine will not breack to the next line wich will allow 
        Console.WriteLine ("chump");       // you to make it so you can add more text with the next argument or make it so
                                           // you can have some type in something next to the text

        Console.Write ("Hello what is your name? ");
        string name = Console.ReadLine ();  //Readline allows you to read in text that a user inputs and store it in a variable
                                            //and it also a just a Read like the WriteLine and Write

        Console.WriteLine ($"Your name is {name}");  //the $ in the WriteLine allows you to format it and put in variables in {}.

        int number = 12;     //int allows you to store a whole number
        double floater = 12.12; //double allows you to store a floating number.

        // if statements will go through sequntualy and if true will run the next line of code if not it will go to the next else if or else statement

        if (number > floater)
        {
            Console.WriteLine($"{number} is greater than {floater}");
        }
        else if (floater > number)
        {
            Console.WriteLine($"{floater} is greater than {number}");
        }
        else
        {
            Console.WriteLine($"{number}, {floater} are equal");
        }

        name = "Larry";
        //Loops, while loops will continue to to run until argument is not true
        while (name == "Larry")
        {
            Console.Write ("Change your name Larry. ");
            name = Console.ReadLine ();
        }
    }
}