// Creating Class Menu

using System.Linq.Expressions;
using System.Net;
using System.Reflection.Metadata;

public class Menu
{
    //List for saving entrys into
    List<string> entrys = new List<string>();

    bool Loop = true;

    public void RunMenu()
    {
        string UserChoice = "0";
        bool loop = true;
        //Menu loop that will quit once user quits
        while (loop)
        {
            DisplayMenu();
            
        }
    }
    //While loop to display menu until user is done

    public void DisplayMenu()
    {
        Console.WriteLine("1. Write New Entry");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
    }
}