
namespace FitnessCenter;
public class UI
{
    //Properties
    // Uncomment this once Member child classes are built
    //public Dictionary<string, Member> Members { get; set; }
    public List<Club> Clubs { get; set; }

    //Constructor
    public UI()
    {
        throw new NotImplementedException();
    }

    //Methods
    public bool CheckIfMemberExists(string ID)
    {
        throw new NotImplementedException();
    }

    public void MainPage()
    {
        Console.WriteLine("Welcome to the GC Fitness Center. How can we help you today?");
        Console.WriteLine("______________________________________________________");
        Console.WriteLine("1. Add Member Screen");
        Console.WriteLine("2. Remove member");
        Console.WriteLine("3. Check in Member");
        Console.WriteLine("4. Check out Member");
        Console.WriteLine("5. Display member info");
        Console.WriteLine("6. Check balance");
        Console.WriteLine("7. Exit");
        Console.WriteLine("Please enter the # of your option.");
        string option = Console.ReadLine();
        if (option == "1")
        {
            AddMemberScreen();
        }
        else if (option == "2")
        {
            RemoveMemberScreen();
        }
        else if (option == "3")
        {
            CheckInScreen();
        }
        else if (option == "4")
        {
            CheckOutScreen();
        }
        else if (option == "5")
        {
            DisplayMemberInfo();
        }
        else if (option == "6")
        {
            CheckBalance();
        }
        else if (option =="7")
        {
            Console.WriteLine("Exiting program...Goodbye!");
            return;
        }
        else
        {
            Console.WriteLine("Invalid option. Please type a number from 1 to 7.");
        }
    }

    public void AddMemberScreen()
    {
        throw new NotImplementedException();
    }

    public void RemoveMemberScreen()
    {
        throw new NotImplementedException();
    }

    public void CheckInScreen()
    {
        throw new NotImplementedException();
    }

    public void CheckOutScreen()
    {
        throw new NotImplementedException();
    }

    public void DisplayMemberInfo()
    {
        throw new NotImplementedException();
    }

    public void CheckBalance()
    {
        throw new NotImplementedException();
    }

    public void Exit()
    {
        throw new NotImplementedException();
    }



}
