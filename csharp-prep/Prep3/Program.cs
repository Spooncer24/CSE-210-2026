using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Welcome to the number guessing game!");

        //Create a random number generater and generate a random number fo the game
        Random RandomGenerator = new Random();
        int MagicNum = RandomGenerator.Next(1, 50);

        //Initiate varibail guess so it can be used in loop
        int guess = -1;

        //Loop if guess does not equal MagicNum then it will tell you higher or lower then have you guess again
        while (guess != MagicNum)
        {
            //have the user start with a guess
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < MagicNum)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > MagicNum)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Congrats!!! Thats Correct!");
            }
        }
    }
}