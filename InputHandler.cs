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
        StudentRegistrationCourse studentRegistrationCourse = new StudentRegistrationCourse();
        public void MoveToSpecificOption(int menuChoice)
        {
            if (menuChoice == 1)
            {
                studentRegistrationCourse.DisplayAllStudents();
            }
            else if (menuChoice == 2)
            {
                Students students = new Students();
                studentRegistrationCourse.GetStudentObject(students);
            }
            else if (menuChoice == 3)
            {
                Registration registration = new Registration();
                studentRegistrationCourse.GetRegistrationObject(registration);

            }
            else if (menuChoice == 4)
            {
                Course course = new Course();
                studentRegistrationCourse.GetCourseObject(course);
            }
            else if (menuChoice == 5)
            {
                studentRegistrationCourse.DisplayStudentRegistration(123456);
            }
            else if (menuChoice == 6)
            {
                Classes classes = new Classes();
                studentRegistrationCourse.GetClassesObject(classes);
            }

            else if (menuChoice == 7)
            {
                Classes classes = new Classes();
                classes.CreateSubjectTuple();
                foreach (var subjects in classes.Subjects.Keys)
                {
                    int keyForId = 156243;
                    Console.WriteLine("keys" + subjects.ToString());
                    
                }

    
                }


            }
        }
    }


}

