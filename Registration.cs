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

        private List<int> idList = new List<int>();
        private List<int> schoolYearList = new List<int>();
        private List<string> semesterList = new List<string>();
        private List<string> programList = new List<string>();
        private List<int> yearLevel = new List<int>();
        public Registration(Students students)
        {
            this.students = students;
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

            bool IsExistingStudentId()
            {
                // !!!! MAKE SURE TO REPLACE 123456 WITH SOMETHING ELSE!
                if (!students.GetStudentIdsList().Contains(123456)) return false;
                return true;
            }
            parsedId = ParseInteger(idInput);
            // default parsedId == 0, if it remains 0 then parsing has failed
            if (parsedId == 0 || !IsSixDigits(parsedId)) return false;
            if (!IsExistingStudentId()) return false;
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
            int parsedSemester;
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
            int highestYearLevel = 4;
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
        public List<int> GetRegistrationIdsList()
        {
            return this.idList;
        }
        public (List<string> lastName, List<String> firstName, List<String> middleName) GetStudentNameList()
        {
            return (this.lastNameList, this.firstNameList, this.middleNameList);
        }

        public List<string> GetStudentSuffix()
        {
            return this.suffixList;
        }
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
                    idList.Add(ParseInteger(userInput));
                }

            }
            while (!isCorrectSchoolYear)
            {
                Console.WriteLine("Enter the school year: ");
                string userInput = Console.ReadLine();
                if (IsValidSchoolYear(userInput))
                {
                    isCorrectSchoolYear = true;
                    schoolYearList.Add(Int32.Parse(userInput));
                }
            }
            while (!isCorrectSemester)
            {
                Console.WriteLine("Enter the semester: ");
                string userInput = Console.ReadLine();
                if (IsValidSemester(userInput))
                {
                    isCorrectSemester = true;
                    semesterList.Add(userInput);
                }
            }
            
            while (!isCorrectProgram)
            {
                Console.WriteLine("Enter the program: ");
                string userInput = Console.ReadLine();
                if (IsValidProgram(userInput))
                {
                    isCorrectProgram = true;
                    programList.Add(userInput);
                }
            }
            
            while (!isCorrectYearLevel)
            {
                Console.WriteLine("Enter the year level: ");
                string userInput = Console.ReadLine();
                if (IsValidYearLevel(userInput))
                {
                    isCorrectYearLevel = true;
                    yearLevel.Add(Int32.Parse(userInput));
                }
            }

        }
    }
}
