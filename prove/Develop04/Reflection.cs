public class Reflection : Activity
{
    Random random = new Random();
    public Reflection() : base("Reflection"){} //Set _activitys variable

    private List<string> reflection = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        private List<string> reflectionQuestions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    public void DisplayDiscription()
    {
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void DisplayReflection()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt.");

        //Get radom index using length of list
        int randomIndex = random.Next(reflection.Count);
        string randomString = reflection[randomIndex];

        Console.WriteLine(randomString);
        Console.WriteLine();
    }

    public string GetReflectionQueston()
    {
        //Get radom index using length of list
        int randomIndex = random.Next(reflectionQuestions.Count);
        string randomString = reflectionQuestions[randomIndex];

        return randomString;
    }
}