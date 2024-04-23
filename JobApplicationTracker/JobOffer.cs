using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobApplicationTracker
{

    public enum Seniority{
        Intern,
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

        public string CompanyName{
            get{return companyName;}
            set{companyName = value;}
        }

        public string Position{
            get{return position;}
            set{position = value;}
        }

        public Seniority Seniority{
            get{return seniority;}
            set{seniority = value;}
        }

        public string Deadline{
            get{return deadline;}
            set{deadline = value;}
        }

        public bool IsApplied{
            get{return isApplied;}
            set{isApplied = value;}
        }

        public static bool IsExpired(string deadline){
            DateOnly _deadline = DateOnly.Parse(deadline);
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);

            return _deadline > currentDate ? false : true;
        }

    }
}