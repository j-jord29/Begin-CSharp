using SnapsLibrary;

public class ThirtySecTimer
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Timer");
        SnapsEngine.DisplayString("You Have 30 Seconds!");
        SnapsEngine.Delay(10);
        SnapsEngine.DisplayString("You Have 20 Seconds!");
        SnapsEngine.Delay(10);
        SnapsEngine.SpeakString("Ten");
        SnapsEngine.DisplayString("10");
        SnapsEngine.SpeakString("Nine");
        SnapsEngine.DisplayString("9");
        SnapsEngine.SpeakString("Eight");
        SnapsEngine.DisplayString("8");
        SnapsEngine.SpeakString("Seven");
        SnapsEngine.DisplayString("7");
        SnapsEngine.SpeakString("Six");
        SnapsEngine.DisplayString("6");
        SnapsEngine.SpeakString("Five");
        SnapsEngine.DisplayString("5");
        SnapsEngine.SpeakString("Four");
        SnapsEngine.DisplayString("4");
        SnapsEngine.SpeakString("Three");
        SnapsEngine.DisplayString("3");
        SnapsEngine.SpeakString("Two");
        SnapsEngine.DisplayString("2");
        SnapsEngine.SpeakString("One");
        SnapsEngine.DisplayString("1");
        SnapsEngine.DisplayString("Time's Up!");
        SnapsEngine.SpeakString("You're Time is up!");


    }
}


