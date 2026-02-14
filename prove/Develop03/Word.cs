using System.Runtime.CompilerServices;

public class Words
{
    private List<string> _words = new List<string>();
    private int hideAmount = 3;
    private int hideTotal = 0;

    public Words(string text)
    {
        // 1. Split the string by spaces and newlines
        // 2. RemoveEmptyEntries handles the extra spaces or line breaks between the verses
        string[] splitWords = text.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in splitWords)
        {
            // If the word is not a number keep it
            if (!int.TryParse(word, out _))
            {
                _words.Add(word);
            }
        }
    }

    public void DisplayWords()
    {
        // Display list of words
        Console.WriteLine(string.Join(" ", _words));
    }

    public void HideWords()
    {
        Random _random = new Random();

        // resets whenever this is called so while loop can use it to keep track
        int hiddenAmount = 0;

        // while loop that runs an amount of times depending on hideAmount variable
        while (hiddenAmount < hideAmount)
        {   
            // Grab random index
            int index = _random.Next(_words.Count);

            // if word in index is already "hidden" skip and try again
            if(_words[index] != "____")
            {
                _words[index] = "____";
                hiddenAmount ++;
            }

            // stop running early if all words are hidden
            if(_words.All(word => word == "____"))
            {
                break;
            }
        }
    }
    public bool CheckHidden()
    {   
        // If all words are hidden reuturn false else return true
        if(_words.All(word => word == "____"))
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}