using SnapsLibrary;

public class TimesTables
{
    public void StartProgram()
    {
        int timesValue = 2;
        
        for (int count = 1; count < 13; count++)
        {
            int result = count * timesValue;
            string message = count.ToString() + " times " + timesValue.ToString() + " is " + result.ToString();

            SnapsEngine.DisplayString(message);
            SnapsEngine.SpeakString(message);
                      
        }
    }
}


