using System; 

// New class Job
public class Job
{
    //Member variables
    public string _jobTitle;

    public string _company;

    public string _startYear;
     public string _endYear;

     //Display job details
     public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}