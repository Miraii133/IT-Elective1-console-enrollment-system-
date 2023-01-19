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
            if (!Int32.TryParse(Console.ReadLine(), out parsedChoice)) return;
            proceedToOption.MoveToSpecificOption(parsedChoice);
            
            }

    }
    class ProceedToSpecificOption
    {
        Students students = new Students();
        public void MoveToSpecificOption(int menuChoice)
        {
          
            if (menuChoice == 1)
            {
                (List<string> lastNameList, List<string> firstNameList, List<string> middleNameList) = students.GetStudentNameList();
                Console.WriteLine(lastNameList[0]);
                Console.WriteLine(firstNameList[0]);
                Console.WriteLine(middleNameList[0]);
            }
            else if (menuChoice == 2)
            {
                students.GetStudentInputs();
                

            }
        }
    }
    

    }

