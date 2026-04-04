public class Listing : Activity
{
    public Listing() : base("Listing"){}  //Set _activitys variable

    private List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        public void DisplayDiscription()
    {
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on the good things in life by haveing you list as many things in a certain area");
    }

        public void DisplayPrompt()
        {
            //Get a prompt from list at random
            Random random = new Random();

            //get random index using random and finding length of list
            int randomIndex = random.Next(prompts.Count);
            string randomPrompt = prompts[randomIndex];

            Console.WriteLine("List as many responses to the following prompt");

            //Display random prompt
            Console.WriteLine();
            Console.WriteLine(randomPrompt);


        }
}