using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobApplicationTracker.Model.Entities;

namespace JobApplicationTracker.View
{
    public class AppScreen
    {
        internal static void Welcome(){
            Console.Clear();
            Console.Title = "Job Tracker Application";

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("--------------------Welcome to Job Application Tracker App--------------------");
            Console.WriteLine("\n");
        }

        internal static void AskUserForOperation(){
            Console.WriteLine("Choose an operation to perform;"
                                + "\n(C)reate"
                                + "\n(R)ead"
                                + "\n(U)pdate"
                                + "\n(D)elete"
                                + "\n(E)xit");
            Utility.GetUserAction();
        }

        internal static void AskUserForOfferDetails(JobOffer jobOffer){
            Console.Clear();

            jobOffer.CompanyName = Utility.GetUserInput("company name");

            jobOffer.Position = Utility.GetUserInput("position");

            Console.WriteLine("\nChoose seniority level:"
                                + "\n1-Intern"
                                + "\n2-Junior"
                                + "\n3-Associate"
                                + "\n4-MidLevel"
                                + "\n5-Senior"
                                + "\n6-Lead"
                                + "\n7-Manager");
            Utility.GetUserInput(jobOffer);
            DateOnly temp;
            string answer = Utility.GetUserInput("application deadline (mm/dd/yy)");
            if(DateOnly.TryParse(answer, out temp)){
                jobOffer.Deadline = answer;
            }
            else{
                Utility.PrintRed("Invalid input!");
            }

            Console.WriteLine("Did you apply to the offer?"
                                + "(Y)es/(N)o");
            jobOffer.IsApplied = Utility.GetUserInput();
            
            Utility.PrintDotAnimation();
        }

        public static void DisplayList(){
            
            for(int i=0; i<JobOfferList._jobs.Count(); i++){
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write("\n{0}- ", i+1);
                Console.Write(JobOfferList._jobs[i].CompanyName);
                Console.Write(", " + JobOfferList._jobs[i].Position);
                Console.Write(", " + JobOfferList._jobs[i].Seniority);
                Console.Write(", " + JobOfferList._jobs[i].Deadline);
                
                if(JobOfferList._jobs[i].IsApplied){
                    Console.WriteLine(", Applied.");
                }
                else{
                    Console.WriteLine(", Didn't Applied.");
                }

                if(JobOffer.IsExpired(JobOfferList._jobs[i].Deadline)){
                    Utility.PrintRed("Deadline has passed!");
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Utility.PressEnterToContinue();
            }
            Utility.PrintGreen("End of the list.");
        }

        
    }
}