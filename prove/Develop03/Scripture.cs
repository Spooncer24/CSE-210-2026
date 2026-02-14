public class Scripture
{
    // Pass "scripter", "Chapter", "start verse", "end verse" into Refernce class constructor
    Reference _reference = new Reference("Poverbs", 3, 5, 6);

    // Pass scripture verse into Words class constructor
    Words _word = new Words("Trust in the Lord with all thine heart; and lean not unto thine own understanding. 6 In all thy ways acknowledge him, and he shall direct thy paths.");

    bool loop = true;
    string quit;
    public void DisplayScripture()
    {   
        //Get refence string from Reference Class
        string reference = _reference.ScriptureReference();

        while(loop)
        {   
            //Clear console
            Console.Clear();

            //Dispay reference
            Console.Write($"{reference} ");

            //Diplay scripture
            _word.DisplayWords();

            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to quit: ");
            quit = Console.ReadLine();

            // Check and see if all words are hidden
            loop = _word.CheckHidden();

            // Hide words
            _word.HideWords();

            // If quit was typed quit the loop and end
            if (quit == "quit")
            {
                loop = false;
            }
        }
    }
}