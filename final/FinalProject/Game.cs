using System.Xml.Serialization;

class Game
{
    public void Menu()
    {
        //super duper epic credit scene and menu
        string credits ="\n\n                                      A Spencer Hewitt Game";

        string menu = @"
        +----------------------------------------------------------------------------------------+
        | ___________      .__                                                                   |
        | \_   _____/_____ |__| ____                                                             |
        |  |    __)_\____ \|  |/ ___\                                                            |
        |  |        \  |_> >  \  \___                                                            |
        | /_______  /   __/|__|\___  >                                                           |
        |         \/|__|           \/                                                            |
        | ________                                               ________                        |
        | \______ \  __ __  ____    ____   ____  ____   ____    /  _____/_____    _____   ____   |
        |  |    |  \|  |  \/    \  / ___\_/ __ \/  _ \ /    \  /   \  ___\__  \  /     \_/ __ \  |
        |  |    `   \  |  /   |  \/ /_/  >  ___(  <_> )   |  \ \    \_\  \/ __ \|  Y Y  \  ___/  |
        | /_______  /____/|___|  /\___  / \___  >____/|___|  /  \______  (____  /__|_|  /\___  > |
        |         \/           \//_____/      \/           \/          \/     \/      \/     \/  |
        +----------------------------------------------------------------------------------------+";

        string options = @"        |                                  Push Enter to Start                                   |
        |                                   Enter ""0"" to quit                                    |
        +----------------------------------------------------------------------------------------+";

        //Show My Epic Credit scene for 3 seconds
        Console.Clear();
        Console.WriteLine(credits);
        Thread.Sleep(3000);

        //Show game title and "game start" and "quit"
        Console.Clear();
        Console.SetCursorPosition(0, 0);
        Console.WriteLine(menu);
        Console.WriteLine(options);
        string choice = Console.ReadLine();
    }
}



  
 

 