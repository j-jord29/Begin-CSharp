using SnapsLibrary;

public class Variables
{
    public void StartProgram()
    {
        string Day = SnapsEngine.GetDayOfWeekName();
        string dayName = SnapsEngine.GetDayOfWeekName();
        SnapsEngine.SpeakString ("It is" + dayName + "my Dudes!"); 

    }
}


