using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital("London,Baker street", 1990, 4, true, 500);

            hospital.AddDepartments(new string[] { "Cardiology", "Emergency department", "Diagnostic" });
            hospital.AddDoctors(new string[] { "A. B. Smith","C. D. Johnson"});
            hospital.AddPacients(new string[] { "Jacky Chan", "Arnold Schwarzenegger", "Steven Seagal" });

            hospital.RemovePacients(new string[] { "Jacky Chan", "Arnold Schwarzenegger", "Steven Seagal" });
        }
    }
}
