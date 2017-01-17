using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    class University:Building
    {
        List<string> lecturers = new List<string>();
        List<string> students = new List<string>();
        List<string> departments = new List<string>();

        public int studentsCount
        {
            get
            { return students.Count; }
        }

        public int lecturersCount
        {
            get { return lecturers.Count; }
        }

        public University(string address, int dateOfBuilding, int floor, bool hasElevator, int maxPeopleCount)
            : base(address, dateOfBuilding, floor, hasElevator, maxPeopleCount)
        {
        }

        public University(string address,int maxPeopleCount)
                : base(address, maxPeopleCount)
        {
        }

        public void AddDepartments(string[] names)
        {
            departments.AddRange(names);
        }

        public void AddStudents(string[] names)
        {
            if (addPeople(names.Length))
            {
                students.AddRange(names);
                
            }
        }

        public void AddLecturers(string[] names)
        {
            if (addPeople(names.Length))
            {
                lecturers.AddRange(names);
                
            }
        }

        public void RemoveStudents(string[] names)
        {
            deletePeople(names.Length);
            for (int i = 0; i < students.Count; i++)
            {
                students.Remove(names[i]);
            }
           
        }

        public void RemoveLecturers(string[] names)
        {
            deletePeople(names.Length);
            for (int i = 0; i < lecturers.Count; i++)
            {
                lecturers.Remove(names[i]);
            }
        }
    }
}
