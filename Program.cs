


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

class SystemControl
{
    static bool isSystemRunning = false;
    public static void StartSystem()
    {
        if (!isSystemRunning) isSystemRunning = true;
    }

    public static void QuitSystem()
    {
        if (isSystemRunning) isSystemRunning = false;
    }

}

class HelperClass {

    // Checks if a choice is valid by parsing string to
    // int and checking for parse exceptions
    public static int ParseStringToInt(String stringToParse)
    {
        int parsedString;
        Int32.TryParse(stringToParse, out parsedString);
        return parsedString;
    }

    


   

    public static void IsInt()
    {

    }

   
     
    public static void DisplayChoices()
    {
        Console.WriteLine(DialogueTexts.ChoicesText);
    }


}

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
    public static Object GetInputs()
    {
        Object input = Console.ReadLine();
        return input;
    }

    public static int GetDialogueChoice()
    {
        string choice = Console.ReadLine();
        int parsedChoice = HelperClass.ParseStringToInt(choice);
        VerifyInputs.IsValidChoice(parsedChoice);
        return parsedChoice;
    }

        public void AskStudentInfo()
    {
        int id;
        string lastName;
        string firstName;
        string middleName;
        string suffix;
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
        Console.WriteLine(id.ToString());
        Console.WriteLine(lastName);
        Console.WriteLine(firstName);
        Console.WriteLine(middleName);
        Console.WriteLine(suffix);
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