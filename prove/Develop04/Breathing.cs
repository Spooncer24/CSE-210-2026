public class Breathing : Activity
{   
    public Breathing() : base("Breathing"){}  //Set _activitys variable in Activitys

    //Display description of activity.
    public void DisplayDiscription()
    {
        Console.WriteLine();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and breathing out slowly.");
    }
}