class LoadAndSave
{
    public void Save(int points, List<Goal> goals)
    {
        //Get file name to save to
        Console.Write("file name to save to (dont add extension): ");
        string filename = Console.ReadLine()+ ".txt";

        //Save each entry to its own line into file named by user
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(points);
            foreach(Goal goal in goals)
            {
                List<object> data = goal.GetGoal();
                outputFile.WriteLine(string.Join("|", data));
            }
        }
    }
    public void Load(ref int points, List<Goal> goals)
    {
        Console.Write("file name to load (dont add extension): ");
        string filename = Console.ReadLine() + ".txt";

        string[] lines = File.ReadAllLines(filename);

        // Take first line out of file for it is used for points
        points = int.Parse(lines[0]);

        goals.Clear();

        // For loop that goes through line by line grabbing the gaols
        for (int i = 1; i < lines.Length; i++)
        {   
            //Split "|" out of file
            string[] parts = lines[i].Split('|');

            //Grab variables and make them into the right variables
            bool complete = bool.Parse(parts[0]);
            string type = parts[1];
            string name = parts[2];
            string description = parts[3];
            int pointsValue = int.Parse(parts[4]);

            if (type == "simple")
            {
                goals.Add(new SimpleGoal(complete, type, name, description, pointsValue));
            }
            else if (type == "eternal")
            {
                goals.Add(new Eternal(complete, type, name, description, pointsValue));
            }
            else if (type == "checklist")
            {
                int bonus = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);
                int completionCount = int.Parse(parts[7]);

                goals.Add(new Checklist(complete, type, name, description, pointsValue, bonus, amountCompleted, completionCount));
            }
        }
    }
}