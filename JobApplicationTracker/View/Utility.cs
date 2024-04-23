using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using JobApplicationTracker.Controller;

namespace JobApplicationTracker.View
{
    public class Utility
    {
        public static void GetUserAction(){
            switch(Console.ReadLine()){
                case "C":
                case "c":
                    JobTrackerApp.CreateOffer();
                    break;
                case "R":
                case "r":
                    JobTrackerApp.ReadOffer();
                    break;
                case "U":
                case "u":
                    JobTrackerApp.UpdateOffer();
                    break;
                case "D":
                case "d":
                    JobTrackerApp.DeleteOffer();
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"Enter {prompt}");
            return Console.ReadLine();
        }

        public static void GetUserInput(JobOffer jobOffer)
        {
            int i = int.Parse(Console.ReadLine());
            switch(i){
                case 1:
                    jobOffer.Seniority = Seniority.Intern;
                    break;
                case 2:
                    jobOffer.Seniority = Seniority.Junior;
                    break;
                case 3:
                    jobOffer.Seniority = Seniority.Associate;
                    break;
                case 4:
                    jobOffer.Seniority = Seniority.MidLevel;
                    break;
                case 5:
                    jobOffer.Seniority = Seniority.Senior;
                    break;
                case 6:
                    jobOffer.Seniority = Seniority.Lead;
                    break;
                case 7:
                    jobOffer.Seniority = Seniority.Manager;
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }

        public static bool GetUserInput(){
            string answer = Console.ReadLine();
            switch(answer){
                case "Y":
                case "y":
                    return true;
                case "N":
                case "n":
                    return false;
                default:
                    return false;
            }
        }
        public static void PressEnterToContinue()
        {
            Console.WriteLine("\n\nPress enter to continue...\n");
            Console.ReadLine();
        }
    }
}