using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValmoriaLab2
{

        class VerifyInputs
        {

            // checks if the inputted value in menu is correct/existing
            public static Boolean IsValidChoice(int parsedChoice)
            {
                if (parsedChoice <= 0 || parsedChoice > 6)
                {
                    Console.WriteLine("ERROR: INVALID CHOICE");
                    return false;
                }
                return true;
            }

            // checks if the Inputted value is correct/follows proper formatting
            public static void IsValidInput(int selectedChoice, int index)
            {

            }

        }


        class RetrieveInputs
        {
        private int id;
        private string lastName;
        private string firstName;
        private string middleName;
        private string suffix;
        private int menuChoice;
            public static Object GetInputs()
            {
                Object input = Console.ReadLine();
                return input;
            }


            public void GetDialogueChoice()
            {
                string choice = Console.ReadLine();
                int parsedChoice = HelperClass.ParseStringToInt(choice);
                VerifyInputs.IsValidChoice(parsedChoice);
                menuChoice = parsedChoice;
                
                ProceedToSpecificOption proceedToOption = new ProceedToSpecificOption();
            
                proceedToOption.MoveToSpecificOption(menuChoice);
            
            }

            public void AskStudentInfo()
            {
                Console.WriteLine("Enter student's 6 digit code: ");
                id = HelperClass.ParseStringToInt(GetInputs().ToString());
                Console.WriteLine("Enter student's last name: ");
                lastName = GetInputs().ToString();
                Console.WriteLine("Enter student's first name: ");
                firstName = GetInputs().ToString();
                Console.WriteLine("Enter student's middle name: ");
                middleName = GetInputs().ToString();
                Console.WriteLine("Enter student's suffix. Leave blank if none: ");
                suffix = GetInputs().ToString();
            }
        }
    class ProceedToSpecificOption
    {
        public void MoveToSpecificOption(int menuChoice)
        {
            if (menuChoice == 1)
            {
                RetrieveInputs rt = new RetrieveInputs();
                rt.AskStudentInfo();
            }
        }
    }
    

    }

