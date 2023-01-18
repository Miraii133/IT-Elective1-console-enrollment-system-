
using ValmoriaLab2;

class HelperClass
{
    public int ParseStringToInt(String stringToParse)
    {
        int result = 0;
        try
        {
           result = Int32.Parse(stringToParse);
        }
        catch (Exception ex)
        {
            Console.WriteLine("ERROR: Not a valid number!");
            Console.WriteLine(ex.Message);
        }
        return result;
    }

}

class StoreDialogueTexts {
    public const string ChoicesText = 
        "AdDU's Command Line Enrollment\n" +
        "1. List all students\n" +
        "2. Add a student\n" +
        "3. Register a student\n" +
        "4. Add a course to a registration\n" +
        "5. Display a student's registration\n" +
        "6. Exit\n";
    
}

class PrintDialogues
{
    public static void PrintChoicesText()
    {
        Console.WriteLine(StoreDialogueTexts.ChoicesText);
    }
}

class SystemControl
{
    public static bool isSystemRunning = false;
    public static void StartSystem()
    {
        if (!isSystemRunning) isSystemRunning = true;
        MenuControl.StartChoicesLoop();
    }

    public static void QuitSystem()
    {
        if (isSystemRunning) isSystemRunning = false;
    }

}


class MenuControl
{
    // Starts the entire menu loop, ask the question for their menu choice,
    // ask their inputs, then repeat to asking the question for menu choice
    public static void StartChoicesLoop()
    {
        while (SystemControl.isSystemRunning)
        {
            PrintDialogues.PrintChoicesText();
            RetrieveInputs retInput = new RetrieveInputs();
            retInput.GetDialogueChoice();
        }
    }
}





class Registration
{
    
}

class Course
{
    public Course(int a, int b)
    {

    }

}

class Subjects
{
    
}


public class main
{
    static void Main()
    {
        SystemControl.StartSystem();
        RetrieveInputs rt = new RetrieveInputs();
        rt.AskStudentInfo();
    }
}