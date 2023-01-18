using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            /*idArray.Add(id);
            nameArray.Add(name);
            contactNumberArray.Add(contactNumber);*/
            //ReadArrays();

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




        private void GetStudentInputs()
        {
            bool isCorrectId = false;

            while (!isCorrectId)
            {
                Console.WriteLine("Enter student's 6 digit code: ");
                if (isValidId(Console.ReadLine())) isCorrectId = true;
            }
           
            


            /*
            Console.WriteLine("Enter student's last name: ");
            lastNameList = GetInputs().ToString();
            Console.WriteLine("Enter student's first name: ");
            firstName = GetInputs().ToString();
            Console.WriteLine("Enter student's middle name: ");
            middleName = GetInputs().ToString();
            Console.WriteLine("Enter student's suffix. Leave blank if none: ");
            suffix = GetInputs().ToString();*/
        }
    }


}

