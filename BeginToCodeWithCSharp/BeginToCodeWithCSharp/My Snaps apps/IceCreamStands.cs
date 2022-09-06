using SnapsLibrary;

public class IceCreamStands
{
    public void StartProgram()
    {        
        int standNum;        

        //Enter Number of Stands
        do
        {
            standNum = SnapsEngine.ReadInteger("Enter Number of Stands");
        } while (standNum < 1 | standNum > 11);

        //Enter Sale Numbers
        int[] sales = new int[standNum];
        int displayCount;

        for (int count = 0; count < sales.Length; count++)
        {
            displayCount = count + 1;
            sales[count] = SnapsEngine.ReadInteger("Enter the Sales Number "+ displayCount +":");
        }

        SnapsEngine.ClearTextDisplay();

        for (int count = 0; count < sales.Length; count++)
        {
            displayCount = count + 1;
            SnapsEngine.AddLineToTextDisplay("Sales "+ displayCount + ": "+ sales[count]);
        }

        string command = SnapsEngine.SelectFrom6Buttons(
            "Low to High",
            "High to Low",
            "Highest and Lowest",
            "Total Sales",
            "Average Sales",
            "Enter Figures");

        if (command == "Low to High")
        {
            for (int pass = 0; pass < sales.Length - 1; pass++)
            {
                bool doneSwap = false;

                for (int i = 0; i < sales.Length - 1 - pass; i++)
                {
                    if (sales[i] > sales[i + 1])
                    {
                        int temp = sales[i];
                        sales[i] = sales[i + 1];
                        sales[i + 1] = temp;
                        doneSwap = true;                   
                    }

                }
                if (!doneSwap)
                {
                    break;
                }

                SnapsEngine.ClearTextDisplay();

                for (int count = 0; count < sales.Length; count += 1)
                {
                    SnapsEngine.AddLineToTextDisplay("Sales: " + sales[count]);
                }

                SnapsEngine.WaitForButton("Continue");
                SnapsEngine.DisplayString("");

            }

        }        
        if (command == "Highest and Lowest")
        {
            int highest = sales[0];
            int lowest = sales[0];

            foreach (int sale in sales)
            {
                if (sale > highest)
                {
                    highest = sale;
                }
                if (sale < lowest)
                {
                    lowest = sale;
                }
                SnapsEngine.DisplayString("Highest: " + highest);
                SnapsEngine.DisplayString("Lowest:" + lowest);

                SnapsEngine.WaitForButton("Continue");
                SnapsEngine.DisplayString("");
            }
        }
        if (command == "Total Sales")
        {
            int total = 0;
            foreach(int sale in sales)
            {
                total = total + sale;
            }
        }
        if (command == "Average Sales")
        {
            int total = 0;

            foreach(int sale in sales)
            {
                total = total + sale;               
            }
            float average = total / sales.Length;
            SnapsEngine.DisplayString("Average Sales: " + average);

            SnapsEngine.WaitForButton("Continue");
            SnapsEngine.DisplayString("");
        }
    }
}


