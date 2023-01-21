
using ValmoriaLab2;
class StoreDialogueTexts
{
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
    public bool isSystemRunning = false;
    public void StartSystem(SystemControl sysControl)
    {
        if (!isSystemRunning) isSystemRunning = true;
        MenuControl menuControl = new MenuControl(sysControl);
        menuControl.StartChoicesLoop();
    }

    public void QuitSystem()
    {
        if (isSystemRunning) isSystemRunning = false;
    }

}


class MenuControl
{
    SystemControl sysControl;
    public MenuControl(SystemControl systemControl)
    {
        this.sysControl = systemControl;
    }
    // Starts the entire menu loop, ask the question for their menu choice,
    // ask their inputs, then repeat to asking the question for menu choice
    public void StartChoicesLoop()
    {
        DialogueChoice choice = new DialogueChoice();
        while (sysControl.isSystemRunning)
        {
            PrintDialogues.PrintChoicesText();
            choice.GetDialogueChoice();
        }
    }
}





public class main
{
    static void Main()
    {
        SystemControl sysControl = new SystemControl();
        sysControl.StartSystem(sysControl);
    }
}