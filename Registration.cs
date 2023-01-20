using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ValmoriaLab2
{
   class Registration {

        Students students;
        private Dictionary<int, Students> studentsList = new Dictionary<int, Students>();
        private int schoolYear;
        private string semester;
        private string program;
        private int yearLevel;

        public int SchoolYear  // property
        {
            get { return schoolYear; }
            set { schoolYear = value; }
        }
        public string Semester   // property
        {
            get { return semester; }
            set { semester = value; }
        }
        public string Program   // property
        {
            get { return program; }
            set { program = value; }
        }
        public int YearLevel   // property
        {
            get { return yearLevel; }
            set { yearLevel = value; }
        }

        public void GetStudentsObject(Students students)
        {
            this.students = students;
            studentsList.Add(students.Id, students);
        }

        public void ReadStudentsList()
        {
                Console.WriteLine(students.Id + "Id");
                Console.WriteLine(students.LastName + " lastName");
                Console.WriteLine(students.FirstName + " FirstName");
                Console.WriteLine(students.MiddleName + " MiddleName");
                Console.WriteLine(students.Suffix + " Suffix");
        }

        // IsNumerical only returns if a string is numerical, i.e. contains numbers/are entirely numbers
        // or not
        private bool IsNumerical(string userInput)
        {
            if (!Int32.TryParse(userInput, out int parsedUserInput)) return false;
            return true;
        }
        // ParseInteger parses the userInput string to int
        int ParseInteger(string userInput)
        {
            
            if (!Int32.TryParse(userInput, out int parsedToInt))
            {
                Console.WriteLine("ERROR: You have a non-number character.");
            }
            return parsedToInt;
        }

        private bool IsValidId(string idInput)
        {
            int idDigitsRequired = 6;
            int parsedId = 0;

            bool IsSixDigits(int parsedId)
            {
                bool isSixDigits = parsedId.ToString().Length == idDigitsRequired;
                if (!isSixDigits) Console.WriteLine("ERROR: Make sure you have inputted a 6 Digit Code.");
                return isSixDigits;
            }

           /* bool IsExistingStudentId()
            {
                // !!!! MAKE SURE TO REPLACE 123456 WITH SOMETHING ELSE!
                if (!students.GetStudentIdsList().Contains(123456)) return false;
                return true;
            }*/
            parsedId = ParseInteger(idInput);
            // default parsedId == 0, if it remains 0 then parsing has failed
            if (parsedId == 0 || !IsSixDigits(parsedId)) return false;
            //if (!IsExistingStudentId()) return false;
            return true;
        }

        private bool IsValidSchoolYear(string schoolYear)
        {
            int parsedSchoolYear = 0;
            int schoolyearDigitsRequired = 4;
            bool IsFourDigits()
            {
                bool isFourDigits = schoolYear.Length == schoolyearDigitsRequired;
                if (!isFourDigits) Console.WriteLine("ERROR: Make sure you have inputted a 4 Digit school year.");
                return isFourDigits;
            }

            parsedSchoolYear = ParseInteger(schoolYear);
            // default parsedSchoolYear == 0, if it remains 0 then parsing has failed
            if (parsedSchoolYear == 0 || !IsFourDigits()) return false;
            return true;
        }

        private bool IsValidSemester(string semesterInput)
        {
            bool IsInListOfSemesters()
            {
                string[] validSemester = { "First Semester", "Second Semester", "Summer" };
                foreach (string semester in validSemester)
                {
                    if (semester.Equals(semesterInput)) return true;
                }
                Console.WriteLine("ERROR: Invalid Semester! Semesters: First Semester, Second Semester, Summer");
                return false;
            }
            if (IsNumerical(semesterInput))
            {
                Console.WriteLine("ERROR: You have a number in your input.");
                return false;
            }
            if (!IsInListOfSemesters()) return false;
            return true;
        }

        private bool IsValidProgram(string semesterInput)
        {
            // would add further validations if a program exists or not but
            // no further implementation required
            if (IsNumerical(semesterInput))
            {
                Console.WriteLine("ERROR: You have a number in your input.");
                return false;
            }
            return !IsNumerical(semesterInput);
        }

        private bool IsValidYearLevel(string yearLevelInput)
        {
            int lowestYearLevel = 1;
            int highestYearLevel = 5;
            bool IsWithinRangeOfValidLevel()
            {
                int parsedYearLevel = ParseInteger(yearLevelInput);
                if (parsedYearLevel < lowestYearLevel || parsedYearLevel > highestYearLevel)
                {
                    Console.WriteLine("ERORR: Invalid year level.");
                    return false;
                }
                return true;
            }
            if (!IsNumerical(yearLevelInput))
            {
                Console.WriteLine("ERROR: Your input must be numerical");
                return false;
            }
            if (!IsWithinRangeOfValidLevel()) return false;
            return true;
        }
        /*public List<int> GetRegistrationIdsList()
        {
           // return this.idList;
        }*/


        public void GetRegistrationInputs()
        {
            bool isCorrectId = false;
            bool isCorrectSchoolYear = false;
            bool isCorrectSemester = false;
            bool isCorrectProgram = false;
            bool isCorrectYearLevel = false;
            while (!isCorrectId)
            {
                Console.WriteLine("Enter the student's ID: ");
                string userInput = Console.ReadLine();
                if (IsValidId(userInput))
                {
                    isCorrectId = true;
                    //idList.Add(ParseInteger(userInput));
                }

            }
            while (!isCorrectSchoolYear)
            {
                Console.WriteLine("Enter the school year: ");
                string userInput = Console.ReadLine();
                if (IsValidSchoolYear(userInput))
                {
                    isCorrectSchoolYear = true;
                    schoolYear = ParseInteger(userInput);
                }
            }
            while (!isCorrectSemester)
            {
                Console.WriteLine("Enter the semester: ");
                string userInput = Console.ReadLine();
                if (IsValidSemester(userInput))
                {
                    isCorrectSemester = true;
                    semester = userInput;
                }
            }
            
            while (!isCorrectProgram)
            {
                Console.WriteLine("Enter the program: ");
                string userInput = Console.ReadLine();
                if (IsValidProgram(userInput))
                {
                    isCorrectProgram = true;
                    program = userInput;
                }
            }
            
            while (!isCorrectYearLevel)
            {
                Console.WriteLine("Enter the year level: ");
                string userInput = Console.ReadLine();
                if (IsValidYearLevel(userInput))
                {
                    isCorrectYearLevel = true;
                    yearLevel = ParseInteger(userInput);
                    //yearLevel.Add(Int32.Parse(userInput));
                }
            }

        }
    }
}
