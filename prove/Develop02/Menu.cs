// Creating Class Menu

using System.Linq.Expressions;
using System.Net;
using System.Reflection.Metadata;

public class Menu
{
    // make instant of entry
    Entry entry = new Entry();

    //List for saving entrys into
    List<string> entryList = new List<string>();

    bool Loop = true;

    public void RunMenu()
    {
        string UserChoice = "0";
        bool loop = true;
        //Menu loop that will quit once user quits
        while (loop)
        {
            DisplayMenu();
            
            Console.Write ("What is your choice? ");
            UserChoice = Console.ReadLine();

            // if then statement depending on what user chooses
            if (UserChoice == "1")       //write new entry
            {
                Console.WriteLine();
                entry.getResponse(entryList);
                Console.WriteLine();
            }

            else if (UserChoice == "2")  //display
            {
                Console.WriteLine();

                //for loop to display every entry
                foreach (string i in entryList)
                {
                    Console.WriteLine(i);
                }

                Console.WriteLine();
            }

            else if (UserChoice == "3")  //save
            {
                Console.WriteLine();
                Save(entryList);
                Console.WriteLine();
            }

            else if (UserChoice == "4")  //load
            {
                Console.WriteLine();
                entryList = Load(entryList);
                Console.WriteLine();
            }

            else if (UserChoice == "5")  //quit
            {
                loop = false;
            }
        }
    }

    //Saves input list to file
    public void Save(List<string> list)
    {
        string filename = "journal.txt";

        Console.WriteLine("Saving to file...");
        
        //Save each entry to its own line in journal.txt
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(string i in list)
            {
                outputFile.WriteLine(i);
            }
        }
    }

    //Loads file into a list
    public List<string> Load(List<string> list)
    {
        Console.WriteLine("Loading...");
        string fileName = "journal.txt";

        //Read file lines and store in string array
        string[] lines = System.IO.File.ReadAllLines(fileName);

        //For each line in the file add it to the list
        foreach (string line in lines)
        {
            list.Add(line);
        }

        return list;
    }

    public void DisplayMenu()
    {
        Console.WriteLine("1. Write New Entry");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
    }
}