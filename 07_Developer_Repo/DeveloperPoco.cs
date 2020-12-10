using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Developer_Repo
{
    public class DeveloperPoco
    {
        //Properties
        public string DeveloperName { get; set; }
        public int IdNumber { get; set; }
        public string PluralsightAccess { get; set; }

        //Constructors 
        public DeveloperPoco() { }
        public DeveloperPoco (string developerName, int idNumber, string pluralsightAccess)
        {
            DeveloperName = developerName;
            IdNumber = idNumber;
            PluralsightAccess = pluralsightAccess;
        }
    }
}
