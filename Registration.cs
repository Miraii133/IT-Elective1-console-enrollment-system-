﻿using System;
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

        private List<string> schoolYearList = new List<string>();
        public Registration(Students students)
        {
            this.students = students;
        }
        private bool isValidId(string idInput)
        {
            int idDigitsRequired = 6;
            int parsedId = 0;

            int ParseInteger()
            {
                if (!Int32.TryParse(idInput, out parsedId))
                {
                    Console.WriteLine("ERROR: You have a non-number character.");
                }
                return parsedId;
            }
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
            parsedId = ParseInteger();
            // default parsedId == 0, if it remains 0 then parsing has failed
            if (parsedId == 0 || !IsSixDigits(parsedId)) return false;
            if (!IsExistingStudentId()) return false;
            return true;
        }

        private bool IsValidSchoolYear(string schoolYear)
        {
            int parsedSchoolYear = 0;
            int schoolyearDigitsRequired = 4;
            int ParseInteger(string schoolYear)
            {
                if (!Int32.TryParse(schoolYear, out parsedSchoolYear))
                {
                    Console.WriteLine("ERROR: You have a non-number character.");
                }
                return parsedSchoolYear;
            }
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
            bool IsNotNumerical()
            {
                Regex regex = new Regex(@"^[a-zA-z\s]+$");
                return regex.IsMatch(semesterInput);
            }

            bool IsValidSchoolYear()
            {
                string[] validSemester = { "First Semester", "Second Semester", "Summer" };
                foreach (string semester in validSemester)
                {
                    if (semester.Contains(semesterInput)) return true;
                }
                return false;
            }
            return IsNotNumerical() && IsValidSchoolYear();
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
                if (isValidId(userInput))
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
                    schoolYearList.Add(userInput);
                }
            }
            /*while (!isCorrectSemester)
            {
                Console.WriteLine("Enter the semester: ");
                string userInput = Console.ReadLine();
                if (isValidName(userInput))
                {
                    isCorrectSemester = true;
                    firstNameList.Add(userInput);
                }
            }
            while (!isCorrectProgram)
            {
                Console.WriteLine("Enter the program: ");
                string userInput = Console.ReadLine();
                if (isValidName(userInput))
                {
                    isCorrectProgram = true;
                    middleNameList.Add(userInput);
                }
            }
            while (!isCorrectYearLevel)
            {
                Console.WriteLine("Enter the year level: ");
                string userInput = Console.ReadLine();
                if (isValidSuffix(userInput))
                {
                    isCorrectYearLevel = true;
                    suffixList.Add(userInput);
                }
            }*/

        }
    }
}
