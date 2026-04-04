public class Activity
{   
    private string _activity;
    protected int _duration = 30;

    private List<string> spinner = new List<string>
        {
            "|", "/", "-", "\\", "|", "/", "-", "\\"
        };

    public Activity(string activity)
    {
        _activity = activity;
    }

    //Display
    public void DisplayWelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_activity} activity");
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"You have completed the {_activity} activity");
        Thread.Sleep(3000);
    }

    //Get how long user wants to do activity
    public void SetDuration()
    {
        Console.WriteLine();
        Console.Write("How long (in seconds) would you like to do this activity for? ");
        int duration = Convert.ToInt32(Console.ReadLine());
        _duration = duration;
    }

    public void Exerecise()
    {
        // If breathing exercise was called do breathing exercise
        if (_activity == "Breathing")
        {   
            Breathing breathing = new Breathing();

            // get the amount of loops for breathing activity
            int num_loops = _duration / 10;

            //Long as number of loops is 1 or more it will loop that many times
            while (num_loops > 0)
            {   
                Console.Clear();
                Console.WriteLine("\nBreath in");

                //Breath in countdown loop
                for (int i = 4; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }

                Console.Clear();
                Console.WriteLine("\nNow breath out");

                //Breath out countdown loop
                for(int i = 6; i > 0; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                } 
                num_loops --;
            }
        }
        else if (_activity == "Listing")  //If Activity Listing was selected do listing activity
        {
            Console.Write("You may begin in: ");
            //Timer before activity starts
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            int numberListed = 0; //Set number of items listed to zero to then show off later

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            Console.WriteLine();

            //While loop to get imputs from user for activity lasting as long as duration
            while(DateTime.Now < endTime)
            {
                Console.Write("> ");
                Console.ReadLine();

                numberListed ++;
            }

            Console.WriteLine($"You listed {numberListed} items");
            Console.WriteLine();
            Console.WriteLine("Well done!!!");
        }
        else if (_activity == "Reflection") //If Activity reflecton was selected do reflection
        {
            //Call Reflections
            Reflection reflection = new Reflection();

            Console.WriteLine();
            Console.WriteLine("When you have something in mind press enter:");
            Console.ReadLine();

            Console.Clear();
            Console.Write("Get ready ");

            //count down for get ready
            for (int i = 3; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine("");

            Console.WriteLine("Now awnser the following questions as they related to the experience.");

            Console.Write("You may begin in ");
            for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            //While loop to continue if time has not expired yet from user
            while(DateTime.Now < endTime)
            {
                //Call GetReflectionQuestion and show it to user
                Console.Write(reflection.GetReflectionQueston());

                //put little animation spinner so person know that it is thinking time
                foreach (string s in spinner)
                {
                    Console.Write(s);
                    Thread.Sleep(1000);
                    Console.Write("\b \b"); 
                }
                Console.WriteLine();

            }


        }
    }
}