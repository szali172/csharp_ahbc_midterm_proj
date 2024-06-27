
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
        Console.WriteLine("1. Add Single Club Member");
        Console.WriteLine("2. Add Multi Club Member");
        Console.WriteLine("3. Remove member");
        Console.WriteLine("4. Check in Member");
        Console.WriteLine("5. Check out Member");
        Console.WriteLine("6. Display member info");
        Console.WriteLine("7. Check balance");
        Console.WriteLine("8. Exit");
        Console.WriteLine("Please enter the # of your option.");
        string option = Console.ReadLine();
        if (option == "1")
        {
            //AddSingleClubMember();
        }
        else if (option == "2")
        {
            //AddMultiClubMember();
        }
        else if (option == "3")
        {
            //RemoveMember();
        }
        else if (option == "4")
        {
            //CheckInMember();
        }
        else if (option == "5")
        {
            //CheckOutMember();
        }
        else if (option == "6")
        {
            DisplayMemberInfo();
        }
        else if (option == "7")
        {
            //CheckBalanceMember();
        }
        else if (option =="8")
        {
            Console.WriteLine("Exiting program...Goodbye!");
            return;
        }
        else
        {
            Console.WriteLine("Invalid option. Please type a number from 1 to 7.");
        }

        //throw new NotImplementedException();
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
