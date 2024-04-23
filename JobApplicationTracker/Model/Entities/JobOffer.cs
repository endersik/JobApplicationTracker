using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationTracker
{

    public enum Seniority{
        Intern = 1,
        Junior,
        Associate,
        MidLevel,
        Senior,
        Lead,
        Manager
    }
    public class JobOffer
    {
        private string companyName;
        private string position;
        private Seniority seniority;
        private string deadline;
        private bool isApplied;

        public JobOffer(string companyName = " ", string position = " ", Seniority seniority = Seniority.Intern,
                        string deadline = " ", bool isApplied = false){}

        public string CompanyName{get; set;}

        public string Position{get; set;}

        public Seniority Seniority{get; set;}

        public string Deadline{get; set;}

        public bool IsApplied{get; set;}

        public static bool IsExpired(string deadline){
            DateOnly _deadline = DateOnly.Parse(deadline);
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);

            return _deadline > currentDate ? false : true;
        }

    }
}