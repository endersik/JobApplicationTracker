using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobApplicationTracker.View;

namespace JobApplicationTracker.Controller
{
    public class JobTrackerApp
    {
        public static void CreateOffer(){
            AppScreen.AskUserForOfferDetails();
        }
        public static void ReadOffer(){}
        public static void UpdateOffer(){}
        public static void DeleteOffer(){}
    }
}