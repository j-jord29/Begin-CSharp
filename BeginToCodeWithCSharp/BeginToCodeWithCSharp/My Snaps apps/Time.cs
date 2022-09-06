using SnapsLibrary;

public class Time
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Current Time");
        int hourValue = SnapsEngine.GetHourValue();
        int minuteValue = SnapsEngine.GetMinuteValue();
        SnapsEngine.DisplayString(hourValue + ":" + minuteValue);
        SnapsEngine.SpeakString(hourValue + ":" + minuteValue);
        SnapsEngine.SetDisplayStringSize(60);
    }
}


