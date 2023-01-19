using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValmoriaLab2
{

        class VerifyInputs
        {
        public int ParseInteger(String stringToParse)
        {
            int parsedInt = 0;
            if (!Int32.TryParse(stringToParse, out parsedInt))
            {
                Console.WriteLine("ERROR: You have a non-number character.");
                return parsedInt;
            }
            return parsedInt;
        }
        


    // checks if the inputted value in menu is correct/existing
    public Boolean IsValidChoice(int parsedChoice)
            {
                if (parsedChoice <= 0 || parsedChoice > 6)
                {
                    Console.WriteLine("ERROR: INVALID CHOICE");
                    return false;
                }
                return true;
            }

            // checks if the Inputted value is correct/follows proper formatting
            public void IsValidInput(int selectedChoice, int index)
            {

            }

        }


        class DialogueChoice
        {

        ProceedToSpecificOption proceedToOption = new ProceedToSpecificOption();
        public void GetDialogueChoice()
            {
            int parsedChoice = 0;
            string userInput = Console.ReadLine();
            //if (!Int32.TryParse(userInput, out _)) return;
            parsedChoice = Int32.Parse(userInput);
            proceedToOption.MoveToSpecificOption(parsedChoice);
            
            }

    }
    class ProceedToSpecificOption
    {
        Students students = new Students();
        Registration registration = new Registration();
        public void MoveToSpecificOption(int menuChoice)
        {
            Course course = new Course(students, registration);
            if (menuChoice == 1)
            {
                (List<string> lastNameList, List<string> firstNameList, List<string> middleNameList) = students.GetStudentNameList();
            }
            else if (menuChoice == 2)
            {
                students.GetStudentInputs();
            }
            else if (menuChoice == 3)
            {
                registration.GetStudentsObject(students);
                registration.GetRegistrationInputs();
            }
            else if (menuChoice == 4)
            {
                course.GetCourseInputs();
            }
            else if (menuChoice == 5)
            {

                registration.GetSchoolInfoList();
            }
        }
    }
    

    }

