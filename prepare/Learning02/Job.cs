using System; 

// New class Job
using System;
using System.Security.Cryptography.X509Certificates;

//Create the new class
public class Job
{
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
}