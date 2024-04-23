using JobApplicationTracker.Model.Entities;
using JobApplicationTracker.View;

namespace JobApplicationTracker.Controller
{
    public class JobTrackerApp
    {
        public static void CreateOffer(){
            JobOffer jobOffer= new JobOffer();
            AppScreen.AskUserForOfferDetails(jobOffer);
            JobOfferList._jobs.Add(jobOffer);
            
            AppScreen.PrintGreen("The offer has been successfully created.");
            Utility.PressEnterToContinue();
            
            AppScreen.AskUserForOperation();
        }
        public static void ReadOffer(){
            AppScreen.DisplayList();
            
            AppScreen.AskUserForOperation();
        }
        public static void UpdateOffer(){
            int index = int.Parse(Utility.GetUserInput("index number"));
            AppScreen.AskUserForOfferDetails(JobOfferList._jobs[--index]);
            AppScreen.PrintGreen("The offer has been successfully updated.");

            AppScreen.AskUserForOperation();
        }
        public static void DeleteOffer(){
            int index = int.Parse(Utility.GetUserInput("index number"));
            JobOfferList._jobs.RemoveAt(--index);
            AppScreen.PrintGreen("The offer has been successfully removed.");

            AppScreen.AskUserForOperation();
        }
    }
}