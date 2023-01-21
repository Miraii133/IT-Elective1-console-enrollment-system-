using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValmoriaLab2
{
    class StudentRegistrationCourse
        {
        class 


            private Dictionary<int, Students> studentsList = new Dictionary<int, Students>();
            private Dictionary<int, Registration> registrationList = new Dictionary<int, Registration>();
            //private Dictionary<int, Course> courseList = new Dictionary<int, Course>();
            private List<KeyValuePair<int, Course>> courseList = new List<KeyValuePair<int, Course>>();
            public void GetStudentObject(Students students)
            {
                students.GetStudentInputs();
                AddStudentToList();
                void AddStudentToList()
                {
                    studentsList.Add(students.Id, students);
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
        }
    }


