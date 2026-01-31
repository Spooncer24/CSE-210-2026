// Creating class entry

public class Entry
{
    //Create instance of Prompts and get random prompt out of it
    Prompts prompts = new Prompts();
    string prompt;
    

    public void getResponse(List<string> entrys)
    {
        //Get prompt for entry;
        prompt = prompts.GetPrompt();

        Console.Write(prompt);
        string response = Console.ReadLine();

        //Get the date
        string date = DateTime.Now.ToString("MMM d, yyyy");

        //Combine date, prompt and response into one string to be added to the list
        string responseCombined = date + ": " + prompt + response;

        //Add response into the list so it can be saved later
        entrys.Add(responseCombined);

    }
}