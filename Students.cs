using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValmoriaLab2
{
    class Students
    {
        List<int> idList = new List<int>();
        List<string> lastNameList = new List<string>();
        List<string> firstNameList = new List<string>();
        List<string> middleNameList = new List<string>();
        List<int> contactNumberList = new List<int>();
        List<int> suffix = new List<int>();
        public Students()
        {
            GetStudentInputs();
        }

        private bool isValidId(string idInput)
        {
            int idDigitsRequired = 6;
            int parsedId = 0;

            bool IsSixDigits(int parsedId)
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
            if (parsedId == 0 || !IsSixDigits(parsedId)) return false;
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

        // Have to create this method to retrieve the validatedId after 
        // checking if userInput is a valid integer
        // also have to manually parse since ParseInteger() is nested in isValidId()
        private int GetValidatedId(string userInput)
        {
            int parsedId = 0;
            Int32.TryParse(userInput, out parsedId); return parsedId;
        }




        private void GetStudentInputs()
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
                    idList.Add(GetValidatedId(userInput));
                }
                    
            }

            while (!isCorrectLastName)
            {
                Console.WriteLine("Enter student's 6 digit code: ");
                string userInput = Console.ReadLine();
                if (isValidId(userInput))
                {
                    isCorrectId = true;
                    idList.Add(GetValidatedId(userInput));
                }
            }
            while (!isCorrectFirstName)
            {
                Console.WriteLine("Enter student's 6 digit code: ");
                string userInput = Console.ReadLine();
                if (isValidId(userInput))
                {
                    isCorrectId = true;
                    idList.Add(GetValidatedId(userInput));
                }
            }
            while (!isCorrectMiddleName)
            {
                Console.WriteLine("Enter student's 6 digit code: ");
                string userInput = Console.ReadLine();
                if (isValidId(userInput))
                {
                    isCorrectId = true;
                    idList.Add(GetValidatedId(userInput));
                }
            }
            while (!isCorrectSuffix)
            {
                Console.WriteLine("Enter student's 6 digit code: ");
                string userInput = Console.ReadLine();
                if (isValidId(userInput))
                {
                    isCorrectId = true;
                    idList.Add(GetValidatedId(userInput));
                }
            }

        }

        
    }


}

