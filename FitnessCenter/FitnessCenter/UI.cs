
namespace FitnessCenter;
public class UI
{
    //Properties

    public Dictionary<string, Member> Members { get; set; }
    public List<Club> Clubs { get; set; }

    //Constructor
    public UI(Dictionary<string, Member> members, List<Club> clubs)
    {
        // Initialize Members and Clubs based on provided parameters
        Members = members;
        Clubs = clubs;

       
        if (Clubs == null)
        {
            Clubs = new List<Club>
                {
                    new Club("Club 1", "123 North Street"),
                    new Club("Club 2", "456 South Street"),
                    new Club("Club 3", "789 West Street"),
                    new Club("Club 4", "101 East Street")
                };
        }

        if (Members == null)
        {
            Members = new Dictionary<string, Member>();

            //Members.Add("1", new SingleClubMember("1", "John Doe", Clubs[0]));
            //Members.Add("2", new SingleClubMember("2", "Jane Smith", Clubs[1]));
            //Members.Add("3", new MultiClubMember("3", "Alice Johnson"));
            //Members.Add("4", new MultiClubMember("4", "Bob Brown"));
        }
    }

    //Methods
    public bool CheckIfMemberExists(string ID)
    {
        if (Members.ContainsKey(ID))
        {
            return true;
        }
        else 
        { 
            return false; 
        }
    }

    public Member RequestMember()
    {
        while(true)
        {
            Console.Write("Please enter a member ID: ");
            string memberID = Console.ReadLine();

            if (memberID == null)
            {
                Console.WriteLine("Please pass a valid input");
                continue;
            }

            else if(Members.ContainsKey(memberID)) {
                Console.WriteLine($"Member \"{Members[memberID].Name}\" was found");
                return Members[memberID];
            }

            else
            {
                Console.WriteLine($"The member ID \"{memberID}\" does not exist. Would you like to try again? (y/n)");
                string yOrN = Console.ReadLine();

                if (yOrN == "n")
                {
                    throw new MemberNotFoundException();
                }
          
            }
        }
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
        
        return;
    }

    public void CheckOutScreen()
    {
        throw new NotImplementedException();
    }

    public void DisplayMemberInfo()
    {
        try
        {
            Member member = RequestMember();
            member.DisplayMemberInfo();

            Console.Write("Press Enter to return back to the Main Menu");
            Console.ReadLine();
            MainPage();
        }
        catch (MemberNotFoundException)
        {
            MainPage();
        }

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
