
using ValmoriaLab2;

class HelperClass
{
    public static int ParseStringToInt(String stringToParse)
    {
        int parsedString;
        Int32.TryParse(stringToParse, out parsedString);
        return parsedString;
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



class Students
{
    public static List<int> idArray = new List<int>();
    public static List<string> nameArray = new List<string>();
    public static List<int> contactNumberArray = new List<int>();
    public Students(int id, string name, int contactNumber)
    {
        idArray.Add(id);
        nameArray.Add(name);
        contactNumberArray.Add(contactNumber);
        //ReadArrays();
    }

    public void ReadArrays()
    {
        foreach (int id in idArray)
        {
            Console.WriteLine(id);
        }
        foreach (string name in nameArray)
        {
            Console.WriteLine(name);
        }
        foreach (int contactNumber in contactNumberArray)
        {
            Console.WriteLine(contactNumber);
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