


class DialogueTexts {
    public const string ChoicesText = 
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

    public static T GetInputs<T>()
    {
        T input = Console.ReadLine();
        Console.WriteLine(input);
        return input;
    }

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
    public static void IsValidInputInfo(int selectedChoice, int index)
    {
        
    }

    public static void DisplayChoices()
    {
        Console.WriteLine(DialogueTexts.ChoicesText);
    }

    public static void StartSystem()
    {
        if (!isSystemRunning) isSystemRunning = true;
    }

    public static void QuitSystem()
    {
        if (isSystemRunning) isSystemRunning = false;
    }


}



class RetrieveInputs
{
    public void AskStudentInfo()
    {
        int id;
        string lastName;
        string firstName;
        string middleName;
        string suffix;
        Console.WriteLine("Enter student's 6 digit code: ");
        Console.WriteLine("Enter student's last name: ");
        Console.WriteLine("Enter student's first name: ");
        Console.WriteLine("Enter student's middle name: ");
        Console.WriteLine("Enter student's suffix. Leave blank if none: ");
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
        HelperClass.StartSystem();
        Students stud = new Students(125, "Jiyo", 099578);
        Students stud2 = new Students(123, "Jiyo", 099578);
        stud2.ReadArrays();
    }
}