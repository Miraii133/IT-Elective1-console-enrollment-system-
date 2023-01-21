using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ValmoriaLab2
{
    class Students
    {
        private int id;
        private string lastName;
        private string firstName;
        private string middleName;
        private string suffix;

        public int Id   // property
        {
            get { return id; }
            set { id = value; }
        }
        public string LastName   // property
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string FirstName   // property
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string MiddleName   // property
        {
            get { return middleName; }
            set { middleName = value; }
        }
        public string Suffix   // property
        {
            get { return suffix; }
            set { suffix = value; }
        }



        private bool isValidId(string idInput)
        {
            int idDigitsRequired = 6;
            int parsedId = 0;

            bool IsSixDigits()
            {
                bool isSixDigits = parsedId.ToString().Length == idDigitsRequired;
                if (!isSixDigits) Console.WriteLine("ERROR: Make sure you have inputted a 6 Digit Code.");
                return isSixDigits;
            }

            int ParseInteger()
            {
                if (!Int32.TryParse(idInput, out parsedId))
                {
                    Console.WriteLine("ERROR: You have a non-number character.");
                }
                return parsedId;
            }
            parsedId = ParseInteger();
            // default parsedId == 0, if it remains 0 then parsing has failed
            if (parsedId == 0 || !IsSixDigits()) return false;
            return true;
        }

        private bool isValidName(string name)
        {
            Regex regex = new Regex(@"^[a-zA-z\s]+$");

            return regex.IsMatch(name);
        }
        private bool isValidSuffix(string suffix)
        {
            Regex regex = new Regex(@"^[a-zA-z]+$");

            return regex.IsMatch(suffix);
        }

        /* public int GetStudentIdsList()
         {
             return id;
         }
         public (List<string> lastName, List<String> firstName, List<String> middleName) GetStudentNameList()
         {
             return (lastName, firstName, middleName);
         }
         public List<string> GetStudentSuffix()
         {
             return this.suffix;
         }*/

        public void GetStudentInputs()
        {
            bool isCorrectId = false;
            bool isCorrectLastName = false;
            bool isCorrectFirstName = false;
            bool isCorrectMiddleName = false;
            bool isCorrectSuffix = false;
            while (!isCorrectId)
            {
                Console.WriteLine("Enter student's 6 digit code: ");
                string userInput = Console.ReadLine();
                if (isValidId(userInput))
                {
                    isCorrectId = true;
                    // parse userInput since id is an integer
                    this.Id = Int32.Parse(userInput);

                }

            }

            while (!isCorrectLastName)
            {
                Console.WriteLine("Enter student's last name: ");
                string userInput = Console.ReadLine();
                if (isValidName(userInput))
                {
                    isCorrectLastName = true;
                    this.LastName = userInput;
                }
            }
            while (!isCorrectFirstName)
            {
                Console.WriteLine("Enter student's first name: ");
                string userInput = Console.ReadLine();
                if (isValidName(userInput))
                {
                    isCorrectFirstName = true;
                    this.FirstName = userInput;
                }
            }
            while (!isCorrectMiddleName)
            {
                Console.WriteLine("Enter student's middle name: ");
                string userInput = Console.ReadLine();
                if (isValidName(userInput))
                {
                    isCorrectMiddleName = true;
                    this.MiddleName = userInput;
                }
            }
            while (!isCorrectSuffix)
            {
                Console.WriteLine("Enter student's suffix: ");
                string userInput = Console.ReadLine();
                if (isValidSuffix(userInput))
                {
                    isCorrectSuffix = true;
                    this.Suffix = userInput;
                }
            }

        }





        public class PrintStudents
        {
            private void GetStudentName()
            {

            }

            private void GetStudentRegistration()
            {

            }

            private void GetStudentNumberOfCourses()
            {

            }
        }


    }


}

