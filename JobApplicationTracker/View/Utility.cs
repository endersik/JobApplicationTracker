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
                case "E":
                case "e":
                    break;
                default:
                    PrintRed("Invalid input, try again!");
                    AppScreen.AskUserForOperation();
                    break;
            }
        }

        public static string GetUserInput(string prompt)
        {
            Console.WriteLine($"\nEnter {prompt}: ");
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
                    PrintRed("Invalid input!");
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
                    PrintRed("Invalid input!");
                    return false;
            }
        }
        public static void PressEnterToContinue()
        {
            Console.WriteLine("\n\nPress enter to continue...\n");
            Console.ReadLine();
            Console.Clear();
        }

        public static void PrintDotAnimation(int timer = 10)
        {
            for (int i = 0; i < timer; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }
            Console.WriteLine("\n");
        }

        public static void PrintGreen(string prompt){
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n" + prompt);
            Console.ForegroundColor = ConsoleColor.Blue;

            Utility.PressEnterToContinue();
        }

        public static void PrintRed(string prompt){
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n" + prompt);
            Console.ForegroundColor = ConsoleColor.Blue;

            Utility.PressEnterToContinue();
        }
    }
}