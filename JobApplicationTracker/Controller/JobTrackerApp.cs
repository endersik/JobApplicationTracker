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
            
            Utility.PrintGreen("The offer has been successfully created.");
            Utility.PressEnterToContinue();
            
            AppScreen.AskUserForOperation();
        }
        public static void ReadOffer(){
            AppScreen.DisplayList();
            
            AppScreen.AskUserForOperation();
        }
        public static void UpdateOffer(){
            int input = int.Parse(Utility.GetUserInput("index number"));
            
            if(input > 0 && input <= JobOfferList._jobs.Count){
                AppScreen.AskUserForOfferDetails(JobOfferList._jobs[input-1]);
                Utility.PrintGreen("The offer has been successfully updated.");
            }else{
                Utility.PrintRed("That offer doesn't exist.");
            }
            
            Utility.PressEnterToContinue();
            AppScreen.AskUserForOperation();
        }
        public static void DeleteOffer(){
            int input = int.Parse(Utility.GetUserInput("index number"));
            
            if(input > 0 && input <= JobOfferList._jobs.Count){
                JobOfferList._jobs.RemoveAt(input-1);
                Utility.PrintGreen("The offer has been successfully removed.");
            }else{
                Utility.PrintRed("That offer doesn't exist.");
            }

            Utility.PressEnterToContinue();
            AppScreen.AskUserForOperation();
        }
    }
}