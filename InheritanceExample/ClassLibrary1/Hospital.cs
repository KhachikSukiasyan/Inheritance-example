using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class Hospital : Building
    {
        List<string> pacients = new List<string>();
        List<string> doctors = new List<string>();
        List<string> departments = new List<string>();

        public Hospital(string address, int dateOfBuilding, int floor, bool hasElevator, int maxPeopleCount) 
            : base(address, dateOfBuilding, floor, hasElevator, maxPeopleCount)
        {
        }

        void AddDepartments(string[] names)
        {
            departments.AddRange(names);
        }

        void AddPacients(string[] names)
        {
            if (addPeople(names.Length))
            {
                pacients.AddRange(names);
            }
        }

        void AddDoctors(string[] names)
        {
            if (addPeople(names.Length))
            {
                doctors.AddRange(names);
            }
        }

        void RemovePacients(string[] names)
        {
            if (deletePeople(names.Length))
            {
                for (int i = 0; i < pacients.Count; i++)
                {
                    pacients.Remove(names[i]);
                }
            }
        }

        void RemoveDoctors(string[] names)
        {
            if (deletePeople(names.Length))
               for (int i = 0; i < pacients.Count; i++)
               {
                  doctors.Remove(names[i]);
               }
            
        }

    }
}
