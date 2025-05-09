using System;

class Program
{
    static void Main(string[] args)
    {
        
    
        Job job1 = new Job();
        job1._title = "Software Engineer";
        job1._company = "Nasa";
        job1._startingYear = 2015;
        job1._endingYear = 2020;

        Job job2 = new Job();
        job2._title = "Manager";
        job2._company = "Google";
        job2._startingYear = 2022;
        job2._endingYear = 2023;

        Resume myResume = new Resume();
        myResume._fname = "Allison";
        myResume._lname = "Smith";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    
    }
}