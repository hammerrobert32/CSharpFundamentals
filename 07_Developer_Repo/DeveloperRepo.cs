using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Developer_Repo
{
    public class DeveloperRepo
    {
        //List of developers
        private List<DeveloperPoco> _listOfDevelopers = new List<DeveloperPoco>();

        //Create
        public void AddDeveloperToList(DeveloperPoco developer)
        {
            _listOfDevelopers.Add(developer);
        }

        //Read
        public List<DeveloperPoco> GetDeveloperList()
        {
            return _listOfDevelopers;
        }

        //Update
        public bool UpdateExistingDeveloper(int id, DeveloperPoco newDeveloper)
        {
            //Find that developer
            DeveloperPoco oldDeveloper = GetDeveloperById(id);

            //Update that developer
            if (oldDeveloper != null)
            {
                oldDeveloper.DeveloperName = newDeveloper.DeveloperName;
                oldDeveloper.IdNumber = newDeveloper.IdNumber;
                oldDeveloper.PluralsightAccess = newDeveloper.PluralsightAccess;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool RemoveDeveloperFromList(int id)
        {
            //Find that developer
            DeveloperPoco developer = GetDeveloperById(id);

            if (developer == null)
            {
                return false;
            }
             //Declare count
            int initialCount = _listOfDevelopers.Count;
            //Delete that developer
            _listOfDevelopers.Remove(developer);

            //Verify
            if (initialCount > _listOfDevelopers.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Helper method
        public DeveloperPoco GetDeveloperById(int idNumber)
        {
            foreach (DeveloperPoco dev in _listOfDevelopers)
            {
                if (dev.IdNumber == idNumber)
                {
                    return dev;
                }
            }
            return null;
        }
    }
}
