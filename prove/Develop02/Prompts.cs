//creating prompts class

public class Prompts
{
    Random random = new Random();
    List<string> promptManager = new List<string>
    {
        "What was something you did good today? ",
        "What is something you are greatfull for right now? ",
        "What did you learn today? ",
        "Did you feel the spirit today? ",
        "If you could redo one thing what would that be and why? "
    };

    public string GetPrompt()
    {
        //Get random prompt from prompt list
        string prompt = promptManager[random.Next(promptManager.Count)];
        return prompt;
    }
}