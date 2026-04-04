using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Menu menu =  new Menu();
        Breathing breathing = new Breathing();
        Reflection reflection = new Reflection();
        Listing listing = new Listing();

        bool done = false;

        //While loop to loop menu until user selects quit
        while (!done)
        {
            //Display the menu
            menu.Display();
            //Get choice from user
            string choice = menu.GetChoice();

            if (choice == "1") // Breathing activity
            {
                breathing.DisplayWelcomeMessage();
                breathing.DisplayDiscription();
                breathing.SetDuration();
                breathing.Exerecise();
                breathing.DisplayEndMessage();
            }
            else if (choice == "2") // Listening activity
            {
                listing.DisplayWelcomeMessage();
                listing.DisplayDiscription();
                listing.SetDuration();
                listing.DisplayPrompt();
                listing.Exerecise();
                listing.DisplayEndMessage();
            }   
            else if (choice == "3") // Reflection activity
            {
                reflection.DisplayWelcomeMessage();
                reflection.DisplayDiscription();
                reflection.SetDuration();
                reflection.DisplayReflection();
                reflection.Exerecise();
                reflection.DisplayEndMessage();
            }
            else if (choice == "4" || choice == "quit") //OR (||) being used for many conditions
            {
                done = true;
            }
        }
    }
}