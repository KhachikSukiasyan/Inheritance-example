# Inheritance-example

### Used
## Visual Studio 2015 Community Edition and Microsoft .NET Framework 4.6 

This is an inheritance example in c#.The base class is `Building`.It includes public fields that are typical for any building,such as address,date of building,how much people can stay in there,count of floors, if it has an elevator.

The second class is called `Hospital`.It is derived from `Building`. It keeps information about `doctors`,`patients`, and names of `departments` of Hospital.Also there are functions for adding and removing patients,doctors and departments.

The third class is called `University`. It keeps information about `lecturers`,`students`, and names of `departments` of University.
Also there are functions for adding and removing lecturers,students and departments.


![1](https://github.com/KhachikSukiasyan/Inheritance-example/blob/master/Screenshot.PNG)

Example of using:
``` C#
Hospital hospital = new Hospital("London,Baker street", 1990, 4, true, 500);

hospital.AddDepartments(new string[] { "Cardiology", "Emergency department", "Diagnostic" });
hospital.AddDoctors(new string[] { "A. B. Smith","C. D. Johnson"});
hospital.AddPacients(new string[] { "Jacky Chan", "Arnold Schwarzenegger", "Steven Seagal" });

hospital.RemovePacients(new string[] { "Jacky Chan", "Arnold Schwarzenegger", "Steven Seagal" });

```
