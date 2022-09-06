using SnapsLibrary;

public class Funfair
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Funfair Rides");
        string ride;
        ride = SnapsEngine.SelectFrom5Buttons(
            "River Cruise",
            "Carnival",
            "Jungle Water Splash",
            "Downhill Mountain Run",
            "The Ultimate Coaster");

        SnapsEngine.SetTitleString(ride);

        if (ride == "River Cruise")
        {
            SnapsEngine.DisplayString("There are no age restrictions. Enjoy the ride!");
        }
        else
        {
            // Ride requires age input
            int ageInt = SnapsEngine.ReadInteger("How old are you?");

            SnapsEngine.DisplayString("You are " + ageInt + " years old");
            SnapsEngine.Delay(durationInSeconds: 2);

            if (ride == "Carnival")
            {
                if (ageInt <= 8)
                    SnapsEngine.DisplayString("Sorry, You cannor enter.");

                else
                    SnapsEngine.DisplayString("You are able to go on the ride. Enjoy!");                                
            }

            if (ride == "Jungle Water Splash")
            {
                if (ageInt <= 12)
                    SnapsEngine.DisplayString("Sorry, You cannot enter.");

                else
                    SnapsEngine.DisplayString("You are able to go on the ride. Enjoy!");
            }

            if (ride == "Downhill Mountain Run")
            {
                if (ageInt <= 16)
                    SnapsEngine.DisplayString("Sorry, You cannot enter.");

                else
                    SnapsEngine.DisplayString("You are able to go on the ride. Enjoy!");
            }

            if (ride == "The Ultimate Coaster")
            {
                // Challenging age
                if (ageInt >= 18)
                {
                    // If the age isn't too low
                    if (ageInt > 60)
                    {
                        //Age too high
                        SnapsEngine.DisplayString("Sorry, due to age concerns you are unable to go on the ride");
                    }
                    else
                    {
                        SnapsEngine.DisplayString("You are able to go on the ride. Enjoy!");
                    }
                }
                else
                {
                    SnapsEngine.DisplayString("Sorry, you cannot enter");
                }
            }                             
        }
    }
}


