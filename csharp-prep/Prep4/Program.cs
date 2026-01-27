using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        //Create list to store numbers
        List<int> numbers = new List<int>();

        //initiate Num so it can be used in loop
        int Num = -1;

        Console.WriteLine("Enter in numbers enter 0 if you wish to quit");

        while (Num != 0)
        {
            //Get number from user
            Console.Write("Enter: ");
            Num = int.Parse(Console.ReadLine());

            //add user number to list
            if (Num != 0)
            {
                numbers.Add(Num); 
            }
        }

        //For loop to get sum of numbers
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is {sum}");

        //Find average of numbers given
        float avg = ((float)sum)/numbers.Count;
        Console.WriteLine($"The average is {avg}");

        //Find Biggest number user entered in the list
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is {max}");
    }
}