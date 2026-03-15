using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("how many secends? ");
        int time = int.Parse(Console.ReadLine());

        Console.WriteLine("Hello im a loading thing");


        DateTime futureTime = DateTime.Now.AddSeconds(time);
        
        while(DateTime.Now < futureTime)
        {
            Console.Write("\b/");
            Thread.Sleep(200);
            Console.Write("\b-");
            Thread.Sleep(200);
            Console.Write("\b\\");
            Thread.Sleep(200);
            Console.Write("\b|");
            Thread.Sleep(200);
        }

    }
} 