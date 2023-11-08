using System;


class Program
{
    static void Main(string[] args)
    {
        // First Job instanca
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._companyName = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;
        

        // Second Job instance
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._companyName = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;
        

        // Creating the Resume instance
        Resume myresume = new Resume();
        myresume._name = "Kaneene Joseph";
        myresume._jobs.Add(job1);
        myresume._jobs.Add(job2);
        myresume.DisplayPersonJobDetails();
    
        


    }
}