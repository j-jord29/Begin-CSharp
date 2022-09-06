using SnapsLibrary;

public class PizzaTime
{
    public void StartProgram()
    {
        string url = "ms-appx:///Images/City.jpg";
        SnapsEngine.DisplayImageFromUrl(imageURL: url);
        SnapsEngine.SetTitleString("Pizza Time");

        int cheeseAndtomatoCount = 0;
        int pepperoniCount = 0;
        int bbqchickenCount = 0;
        int vegetarianCount = 0;

        while (true)
        {
            string toppingChoice = SnapsEngine.SelectFrom5Buttons(
            "Cheese and Tomato",
            "Pepperoni",
            "BBQ Chicken",
            "Vegetarian",
            "Show Totals");

            if (toppingChoice == "Cheese and Tomato")
                cheeseAndtomatoCount += 1;

            if (toppingChoice == "Pepperoni")
                pepperoniCount += 1;

            if (toppingChoice == "BBQ Chicken")
                bbqchickenCount += 1;

            if (toppingChoice == "Vegetarian")
                vegetarianCount += 1;

            if (toppingChoice == "Show Totals")
            {
                SnapsEngine.ClearTextDisplay();

                SnapsEngine.AddLineToTextDisplay("Order Totals");
                SnapsEngine.AddLineToTextDisplay(cheeseAndtomatoCount.ToString() + " Cheese And Tomato");
                SnapsEngine.AddLineToTextDisplay(pepperoniCount.ToString() + " Pepperoni");
                SnapsEngine.AddLineToTextDisplay(bbqchickenCount.ToString() + " BBQ Chicken");
                SnapsEngine.AddLineToTextDisplay(vegetarianCount.ToString() + " Vegetarian");

                string reply = SnapsEngine.SelectFrom2Buttons(item1: "Done", item2: "Reset");

                if(reply == "Reset")
                {
                    cheeseAndtomatoCount = 0;
                    pepperoniCount = 0;
                    bbqchickenCount = 0;
                    vegetarianCount = 0;
                }

                //Clears the display off the screen
                SnapsEngine.ClearTextDisplay();
                                
                
            }
        }          
       
    }
}