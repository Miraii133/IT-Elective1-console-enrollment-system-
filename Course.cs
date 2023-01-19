using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ValmoriaLab2;

namespace ValmoriaLab2
{
    class Course
    {
        Students students;
        Registration registration;

        public void GetStudentsObject(Students students)
        {
            this.students = students;
        }

        public void GetRegistrationObject(Registration registration)
        {
            this.registration = registration;
        }

        private List<int> schoolYearList = new List<int>();
        private List<string> semesterList = new List<string>();
        private List<string> programList = new List<string>();
        private List<int> yearLevel = new List<int>();

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

        private bool IsValidClassCode(string classCodeInput)
        {
            // would add further validations if a class code exists or not but
            // no further implementation required
            return true;
        }

        private bool IsValidSubjectCode(string subjectCodeInput)
        {
            if (!IsNumerical(subjectCodeInput))
            {
                Console.WriteLine("ERROR: Make sure you have inputted a 6 Digit subject code.");
                return false;
            }
                return true;
        }

        public void GetCourseInputs()
        {
            bool isCorrectId = false;
            bool isCorrectSchoolYear = false;
            bool isCorrectSemester = false;
            bool isCorrectClassCode = false;
            bool isCorrectSubjectCode = false;
            while (!isCorrectId)
            {
                Console.WriteLine("Enter the student's ID: ");
                string userInput = Console.ReadLine();
                if (IsValidId(userInput))
                {
                    isCorrectId = true;
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

            while (!isCorrectClassCode)
            {
                Console.WriteLine("Enter the class code: ");
                string userInput = Console.ReadLine();
                if (IsValidClassCode(userInput))
                {
                    isCorrectClassCode = true;
                    programList.Add(userInput);
                }
            }

            while (!isCorrectSubjectCode)
            {
                Console.WriteLine("Enter the subject code: ");
                string userInput = Console.ReadLine();
                if (IsValidSubjectCode(userInput))
                {
                    isCorrectSubjectCode = true;
                    yearLevel.Add(Int32.Parse(userInput));
                }
            }

        }
    }

}
