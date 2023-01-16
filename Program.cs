


class DialogueTexts {
    public static string ChoicesText = 
        "AdDU's Command Line Enrollment\n" +
        "1. List all students\n" +
        "2. Add a student\n" +
        "3. Register a student\n" +
        "4. Add a course to a registration\n" +
        "5. Display a student's registration\n" +
        "6. Exit\n";
}



class HelperClass {

    static bool isSystemRunning = false;


    // Checks if a choice is valid by parsing string to
    // int and checking for parse exceptions
    public static int ParseChoice(String choiceInput)
    {
        int parsedChoice;
        Int32.TryParse(choiceInput, out parsedChoice);
        return parsedChoice;
    }
    public static int GetDialogueChoice()
    {
        string choice = Console.ReadLine();
        int parsedChoice = ParseChoice(choice);
        IsValidChoice(parsedChoice);
        return parsedChoice;
    }

    public static Boolean IsValidChoice(int parsedChoice)
    {
        if (parsedChoice <= 0 || parsedChoice > 6)
        {
            Console.WriteLine("INVALID CHOICE");
            return false;
        }
            return true;
    }

    public static void DisplayChoices()
    {
        Console.WriteLine(DialogueTexts.ChoicesText);
    }

    public static void StartSystem()
    {
        if (!isSystemRunning) isSystemRunning = true;
        while (isSystemRunning)
        {
            DisplayChoices();
            GetDialogueChoice();
        }
    }

    public static void QuitSystem()
    {
        if (isSystemRunning) isSystemRunning = false;
    }


}



public class main
{
    static void Main()
    {
        HelperClass.StartSystem();
    }
}