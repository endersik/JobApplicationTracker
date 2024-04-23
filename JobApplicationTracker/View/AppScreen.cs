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
    }
}