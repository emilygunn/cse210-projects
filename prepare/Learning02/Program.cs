using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        //Jobs
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2019";
        job1._endYear = "2022";

        // job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Cybersecurity Analyst";
        job2._startYear = "2022";
        job2._endYear = "2025";

        // job2.DisplayJobDetails();

        //Resume
        Resume myResume = new Resume();
        myResume._name = "Erin Grace";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume.DisplayResumeDetails();
    }
}