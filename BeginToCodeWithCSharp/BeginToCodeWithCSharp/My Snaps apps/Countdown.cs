using SnapsLibrary;

public class Countdown
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Countdown");
        SnapsEngine.SpeakString("Ten");
        SnapsEngine.SpeakString("Nine");
        SnapsEngine.SpeakString("Eight");
        SnapsEngine.SpeakString("Seven");
        SnapsEngine.SpeakString("Six");
        SnapsEngine.SpeakString("Five");
        SnapsEngine.SpeakString("Four");
        SnapsEngine.SpeakString("Three");
        SnapsEngine.SpeakString("Two");
        SnapsEngine.SpeakString("One");
        SnapsEngine.SetTitleString("Blast Off!");
        SnapsEngine.SpeakString("Blast Off!");
        SnapsEngine.SetTitleColor(SnapsColor.Red);
        
    }
}