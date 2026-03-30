using System;

class Program
{
    static void Main(string[] args)
    {
        //Make new job called job1
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Nivida";
        job1._startYear = 1987;
        job1._endYear = 2000;

        //Make new job called job2
        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Apple inc";
        job2._startYear = 2000;
        job2._endYear = 2028;

        //Display job1 and job2
        job1.Display();
        job2.Display();

        //Make the resume
        Resume myResume = new Resume();

        //add a name to resume
        myResume._name = "Spencer Hewitt";

        //add jobs to resume
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Display resume
        myResume.Display();
    }
}