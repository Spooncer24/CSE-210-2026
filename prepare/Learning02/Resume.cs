using System;

public class Resume
{
    public string _name;

    //Make a list for jobs to be added to 
    public List<Job> _jobs = new List<Job>();

    //Display resume with all info that was added
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
        
    }
}