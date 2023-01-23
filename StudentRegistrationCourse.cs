using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValmoriaLab2
{
    class StudentRegistrationCourse
        {

            private Dictionary<int, Students> studentsList = new Dictionary<int, Students>();
            private Dictionary<int, Registration> registrationList = new Dictionary<int, Registration>();
            private List<KeyValuePair<int, Course>> courseList = new List<KeyValuePair<int, Course>>();

            private Dictionary<int, Classes> classesList = new Dictionary<int, Classes>();

            private Dictionary<int, Subjects> subjectsList = new Dictionary<int, Subjects>();
        public void GetStudentObject(Students students)
            {
            students.GetStudentInputs();
                AddStudentToList();
                void AddStudentToList()
                {
                    studentsList.Add(students.Id, students );
                }
            }

            public void GetRegistrationObject(Registration registration)
            {
                registration.GetRegistrationInputs();
                AddRegistrationToList();
                void AddRegistrationToList()
                {
                    registrationList.Add(registration.Id, registration);
                }
            }

            public void GetCourseObject(Course course)
            {
                course.GetCourseInputs();
                AddCourseToList();
                void AddCourseToList()
                {
                    courseList.Add(new KeyValuePair<int, Course>(course.Id, course));
                }
            }

            public void GetClassesObject(Classes classes)
            {
                classes.GetClassesInputs();
                AddClassesToList();
                void AddClassesToList()
                {
                    classesList.Add(classes.ClassCode, classes);
                }

            }

            public void AddCourse()
            {
                foreach (var classes in classesList)
                {
                 //   int id = 
                   // int classCode = classes[];
                }
            }

            public void DisplayAllStudents()
            {
                foreach (var students in studentsList)
                {
                    int keyForId = students.Key;
                    Console.WriteLine("FirstName " + studentsList[keyForId].FirstName);
                    Console.WriteLine("LastName" + studentsList[keyForId].LastName);
                    Console.WriteLine("MiddleName " + studentsList[keyForId].MiddleName);
                    Console.WriteLine("Latest Registration " + registrationList[keyForId].SchoolYear);
                    Console.WriteLine(courseList.Count(k => k.Key == keyForId ));
                    
                }
            }

            public void DisplayStudentRegistration(int studentId)
            {
            
            Console.WriteLine("ID: " + studentsList[studentId].Id);
            Console.WriteLine(
                $"Name: {studentsList[studentId].LastName}, {studentsList[studentId].FirstName} " +
                $"{studentsList[studentId].MiddleName} AY {registrationList[studentId].SchoolYear} - {registrationList[studentId].SchoolYear + 1} " +
                $"{registrationList[studentId].YearLevel}");
            }

        
        }
    }


