using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValmoriaLab2
{

    class Subjects
        {
        public Subjects()
        {
            AddTuplesToList();
        }
       
        // turn tuple into a list where the int is the subjectCode
        private Tuple<int, string, string> programmingParadigm = new Tuple<int, string, string>
            (156243, "IT 110", "Programming Paradigms");

        private Tuple<int, string, string> introToCPlusPlus = new Tuple<int, string, string>
            (143220, "CSC 101", "Introduction To C++ Programming");

        private Tuple<int, string, string> webDevelopment = new Tuple<int, string, string>
            (172523, "IT 124", "Web Development");



        private List<Tuple<int, string, string>> listOfSubjects = new List<Tuple<int, string, string>>();

        public List<Tuple<int, string, string>> ListOfSubjects  // property
        {
            get { return listOfSubjects; }
        }

        private void AddTuplesToList()
        {
            listOfSubjects.Add(programmingParadigm);
            listOfSubjects.Add(introToCPlusPlus);
            listOfSubjects.Add(webDevelopment);
        }

    }

    class Classes
    {
    

        private int classCode;
        private int subjectCode;
        private string schedule;
        public int ClassCode  // property
        {
            get { return classCode; }
            set { classCode = value; }
        }
        public int SubjectCode  // property
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }
        public string Schedule  // property
        {
            get { return schedule; }
            set { schedule = value; }
        }



    /*Dictionary<int, Tuple<int, string, string>> subjectsTuple = new Dictionary<int, Tuple<int, string, string>>();

public Dictionary<int, Tuple<int, string, string>> Subjects  // property
{
    get { return subjectsTuple; }
}

public void CreateSubjectTuple()
    {

        Tuple<int, string, string> programmingParadigm = Tuple.Create(156243, "IT 110", "Programming Paradigms");
        Tuple<int, string, string> introToCPlusPlus = Tuple.Create(143220, "CSC 101", "Introduction To C++ Programming");
        Tuple<int, string, string> webDevelopment = Tuple.Create(172523, "IT 124", "Web Development");
        subjectsTuple.Add(156243, programmingParadigm);
        subjectsTuple.Add(143220, introToCPlusPlus);
        subjectsTuple.Add(172523, webDevelopment);

    }*/

    // Dictionary<int, Tuple<int, string, string>>
    // first int, subjectCode identifier
    // second int, subjectCode identifier


    //private List<int, string, string> programmingParadigm = new List<int, string, string>(); 

        private bool IsNumerical(string userInput)
        {
            if (!Int32.TryParse(userInput, out _)) return false;
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

        private bool IsValidClassCode(string idInput)
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
                //if (!students.GetStudentIdsList().Contains(123456)) return false;
                return true;
            }
            parsedId = ParseInteger(idInput);
            // default parsedId == 0, if it remains 0 then parsing has failed
            if (parsedId == 0 || !IsSixDigits(parsedId)) return false;
            if (!IsExistingStudentId()) return false;
            return true;
        }

        private bool IsValidSubjectCode(string schoolYear)
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

        private bool IsValidSchedule(string semesterInput)
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

        
        public void GetClassesInputs()
        {
            bool isCorrectClassCode = false;
            bool isCorrectSubjectCode = false;
            bool isCorrectSchedule = false;
            while (!isCorrectClassCode)
            {
                Console.WriteLine("Enter class code: ");
                string userInput = Console.ReadLine();
                if (IsValidClassCode(userInput))
                {
                    isCorrectClassCode = true;
                    classCode = ParseInteger(userInput);
                }

            }
            while (!isCorrectSubjectCode)
            {
                Console.WriteLine("Enter subject code: ");
                string userInput = Console.ReadLine();
                if (IsValidSubjectCode(userInput))
                {
                    isCorrectSubjectCode = true;
                    subjectCode = ParseInteger(userInput);
                }
            }
            while (!isCorrectSchedule)
            {
                Console.WriteLine("Enter schedule: ");
                string userInput = Console.ReadLine();
                if (IsValidSchedule(userInput))
                {
                    isCorrectSchedule = true;
                    schedule = userInput;
                }
            }

        }

    }
}
