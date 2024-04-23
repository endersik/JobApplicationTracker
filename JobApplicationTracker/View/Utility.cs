using System;
using System.Collections.Generic;
using System.Linq;
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
        public static void PressEnterToContinue()
        {
            Console.WriteLine("\n\nPress enter to continue...\n");
            Console.ReadLine();
        }
    }
}