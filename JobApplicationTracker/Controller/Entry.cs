using JobApplicationTracker;
using JobApplicationTracker.View;
using System;

namespace JobApplicationTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            AppScreen.AskUserForOperation();

            JobOffer jobOffer= new JobOffer();

            jobOffer.CompanyName = Console.ReadLine();
            Console.WriteLine(jobOffer.CompanyName);

            jobOffer.Position = Console.ReadLine();
            Console.WriteLine(jobOffer.Position);

            jobOffer.Seniority = Seniority.Lead;
            Console.WriteLine(jobOffer.Seniority);

            jobOffer.Deadline = Console.ReadLine();
            Console.WriteLine(jobOffer.Deadline);

            jobOffer.IsApplied = true;
            Console.WriteLine(jobOffer.IsApplied);
            Console.WriteLine(JobOffer.IsExpired(jobOffer.Deadline));
        }
    }
}




