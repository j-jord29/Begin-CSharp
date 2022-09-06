using SnapsLibrary;

public class Dice 
{
    public void StartProgram()
    {
        int spotCount = SnapsEngine.ThrowDice();
        SnapsEngine.SetTitleString(spotCount.ToString());
        SnapsEngine.SpeakString("You have rolled a" + spotCount.ToString());

        if (SnapsEngine.ThrowDice() > 3)
            SnapsEngine.SpeakString("You are going to have good luck");
        else
            SnapsEngine.SpeakString("Nothing Today, Please Try Again Later!");
               
    }
}


