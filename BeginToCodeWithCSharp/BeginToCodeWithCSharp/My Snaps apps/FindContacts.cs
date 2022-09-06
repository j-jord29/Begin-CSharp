using SnapsLibrary;

public class FindContacts
{
    public void StartProgram()
    {
        while (true)
        {
            SnapsEngine.SetTitleString("Contact Finder");
            string command = SnapsEngine.SelectFrom2Buttons("Create Contact", "Find Contact");

            if (command == "Create Contact")
            {
                CreateContact();
            }

            if (command == "Find Contact")
            {
                FindContact();
            }
        }
        
    }

    public void CreateContact()
    {
        SnapsEngine.DisplayString("Enter the Contact Details");
        string name = SnapsEngine.ReadString("Enter Name: ");
        string address = SnapsEngine.ReadMultiLineString("Enter Contact Address: ");
        string number = SnapsEngine.ReadString("Enter Phone Number: ");
        StoreContact(name: name, address: address, number: number);
    }

    void FindContact()
    {
        string name = SnapsEngine.ReadString("Enter Contact Name");

        string contactAddress, contactNumber;

        if (GetContact(name: name, address: out contactAddress, number: out contactNumber))
        {
            SnapsEngine.ClearTextDisplay();

            SnapsEngine.AddLineToTextDisplay("Name: " + name);
            SnapsEngine.AddLineToTextDisplay("Address: " + contactAddress);
            SnapsEngine.AddLineToTextDisplay("Phone: " + contactNumber);
        }
        else
        {
            SnapsEngine.DisplayString("Name Not Found");
        }

        SnapsEngine.WaitForButton("Continue");
        SnapsEngine.ClearTextDisplay();
    }

    public void StoreContact(string name, string address, string number)
    {
        name = TidyString(name);
        SnapsEngine.SaveStringToLocalStorage(itemName: name + ":address", itemValue: address);
        SnapsEngine.SaveStringToLocalStorage(itemName: name + ":number", itemValue: number);        
    }

    bool GetContact(string name, out string address, out string number)
    {
        name = TidyString(name);
        address = SnapsEngine.FetchStringFromLocalStorage(itemName: name + ":address");
        number = SnapsEngine.FetchStringFromLocalStorage(itemName: name + ":number");

        if (address == null || number == null)
        {
            return false;
        }
        return true;
    }
    /// <summary>
    /// Formats the name for search
    /// </summary>
    /// <param name="input"> Name to be formatted </param>
    /// <returns>Tided contact name</returns>
    string TidyString(string input)
    {
        input = input.Trim();
        input = input.ToLower();
        return input;
    }
}


