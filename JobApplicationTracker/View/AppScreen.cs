using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationTracker.View
{
    public class AppScreen
    {
        internal static void Welcome(){
            Console.Clear();
            Console.Title = "Job Tracker Application";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------Welcome to Job Application Tracker App--------------------");
            Console.ForegroundColor = ConsoleColor.White;

            Utility.PressEnterToContinue();
        }

        internal static void AskUserForOperation(){
            Console.Clear();
            Console.WriteLine("Choose an operation to perform;"
                                + "\n(C)reate"
                                + "\n(R)ead"
                                + "\n(U)pdate"
                                + "\n(D)elete");
            Utility.GetUserAction();

        }

        internal static void AskUserForOfferDetails(){
            Console.Clear();

            JobOffer jobOffer= new JobOffer();

            jobOffer.CompanyName = Utility.GetUserInput("company name: ");
            Console.WriteLine(jobOffer.CompanyName);

            jobOffer.Position = Utility.GetUserInput("position: ");
            Console.WriteLine(jobOffer.Position);

            Console.WriteLine("Choose seniority level:"
                                + "\n1-Intern"
                                + "\n2-Junior"
                                + "\n3-Associate"
                                + "\n4-MidLevel"
                                + "\n5-Senior"
                                + "\n6-Lead"
                                + "\n7-Manager");
            Utility.GetUserInput(jobOffer);
            Console.WriteLine(jobOffer.Seniority);

            jobOffer.Deadline = Utility.GetUserInput("application deadline: ");
            Console.WriteLine(jobOffer.Deadline);

            Console.WriteLine("Did you apply to the offer?"
                                + "(Y)es/(N)o");
            jobOffer.IsApplied = Utility.GetUserInput();
            Console.WriteLine(jobOffer.IsApplied);

            Console.WriteLine(JobOffer.IsExpired(jobOffer.Deadline));
        }
    }
}