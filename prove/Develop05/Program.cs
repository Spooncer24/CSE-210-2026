using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Net.Quic;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        LoadAndSave saveLoad = new LoadAndSave();

        List<Goal> goal_list = new List<Goal>();
        // goal_list.Add(new Checklist(false, "checklist", "kiss a bee", "Go out and kiss a bumble bee", 50, 500, 3, 5));
        int totalPoints = 0;

        bool stop = false;
        string option;

        Console.Clear();

        while (stop == false)
        {
            Console.WriteLine("+----------------------------------+");
            Console.WriteLine("|    Welcom to the Goal Program    |");
            Console.WriteLine("| Choose an option to get started. |");
            Console.WriteLine("+----------------------------------+");
            Console.WriteLine("| 1. Create new goal               |");
            Console.WriteLine("| 2. List goals                    |");
            Console.WriteLine("| 3. Save goals                    |");
            Console.WriteLine("| 4. Load Goals                    |");
            Console.WriteLine("| 5. Record Goals                  |");
            Console.WriteLine("| 6. Quit                          |");
            Console.WriteLine("+----------------------------------+");

            string pointsLine = $"| Points: {totalPoints}";
            Console.WriteLine(pointsLine.PadRight(35) + "|");         //This makes sure the points box stays alligned

            Console.WriteLine("+----------------------------------+");


            Console.Write("Option: ");
            option = Console.ReadLine();

            // Create new goal
            if (option == "1")
            {
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("|    Choose goal type to create    |");
                Console.WriteLine("+----------------------------------+");
                Console.WriteLine("| 1. Simple                        |");
                Console.WriteLine("| 2. Checklist                     |");
                Console.WriteLine("| 3. Eternal                       |");
                Console.WriteLine("| 4. Back                          |");
                Console.WriteLine("+----------------------------------+");

                Console.Write("Option: ");
                option = Console.ReadLine();

                //Create a simple or eternal goal.
                if (option == "1" || option == "3") 
                {
                    // Get name of goal and description from user
                    Console.Write("Goal name: "); 
                    string name = Console.ReadLine(); 
                    Console.Write("Goal Description: ");
                    string description = Console.ReadLine();

                    // Get points from user
                    int points = GetInt("How many points is this worth? ");

                    //Construct goal type depending on simple or eternal
                    if (option == "1")
                    {
                        //Take those inputs and creat new simple goal and add it to list
                        goal_list.Add(new SimpleGoal(false, "simple", name, description, points));
                    }
                    if (option == "3")
                    {
                        //Take those inputs and creat new eternal goal and add it to list
                        goal_list.Add(new Eternal(false, "eternal", name, description, points));
                    }
                }
                //Counstruct a checklist goal if chosen
                if (option == "2")
                {
                    // Get name of goal and description from user
                    Console.Write("Goal name: "); 
                    string name = Console.ReadLine(); 
                    Console.Write("Goal Description: ");
                    string description = Console.ReadLine();

                    // Get point worth from user
                    int points = GetInt("How many points is this worth? ");

                    // Get bonus point worth from user
                    int bonusPoints = GetInt("How many bonus points is this worth? ");

                    // Get the length of the goal
                    int length = GetInt("How many Days? ");

                    // Construct checklist goal and add it to list
                    goal_list.Add(new Checklist(false, "checklist", name, description, points, bonusPoints, 0, length));
                }
            }
            // Display Goals
            else if (option == "2")
            {
                Console.WriteLine();

                //splits the goal_list so the interanl list can be brocken up and used to display goals.
                foreach (Goal _goal in goal_list)
                {
                    string goalType = (string)_goal.GetGoal()[1];

                    //Chek to see if goal is completed and assign correct check box.
                    string completed;

                        if ((bool)_goal.GetGoal()[0] == true)
                        {
                            completed = "[x]";
                        }
                        else
                        {
                            completed = "[ ]";
                        }

                    //If checklist goal display goal as: [ ] kiss a bee (Go out and kiss a bee) -- 3/5
                    if (goalType == "checklist")
                    {
                        Console.WriteLine($"{completed} {_goal.GetGoal()[2]} ({_goal.GetGoal()[3]}) -- {_goal.GetGoal()[6]}/{_goal.GetGoal()[7]}");
                    }
                    //If simple or eternal goal diplay as :[ ] kiss a bee (go at and kiss a bee)
                    else
                    {
                        Console.WriteLine($"{completed} {_goal.GetGoal()[2]} ({_goal.GetGoal()[3]})");
                    }
                }
            }
            // Save goals
            else if (option == "3")
            {
                saveLoad.Save(totalPoints, goal_list);
            }
            // Load goals
            else if (option == "4")
            {
                saveLoad.Load(ref totalPoints, goal_list);
            }
            // Record Goals
            else if (option == "5")
            {   
                //new list for goals needing to be completed
                List<int> toComplete = new List<int>();

                //List all goals into a list to choose from
                int counter = 0;
                for (int i = 0; i < goal_list.Count; i++)
                {
                    if (!(bool)goal_list[i].GetGoal()[0])
                    {
                        counter++;
                        Console.WriteLine($"{counter}. {goal_list[i].GetGoal()[2]}");
                        toComplete.Add(i);
                    }
                }
                //get real index of goal location
                int completeChoice = GetInt("What Goal do you want to complete? ");
                //Get the real index
                int realIndex = toComplete[completeChoice - 1];
                //Use real index to complete goal and get points
                int addPoints = goal_list[realIndex].SetComplete();
                //add points gained to total points.
                totalPoints += addPoints;
            }
            // Quit
            else if (option == "6")
            {
                stop = true;
            }
        }
    }

    //Take in descrption string and get a valid int out
    public static int GetInt(string des)
    {
        bool valid = false;
        int intnum = 0;
        while (!valid)
        {
            Console.Write(des);
            string strnum = Console.ReadLine();

            if (int.TryParse(strnum, out intnum))
            {
                valid = true;
            }
            else
            {
            Console.WriteLine("Enter a valid number.");
            }
        }
        return intnum;
    }
}
