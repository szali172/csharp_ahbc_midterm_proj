
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

            Members.Add("1", new SingleClubMember("1", "John Doe", Clubs[0]));
            Members.Add("2", new SingleClubMember("2", "Jane Smith", Clubs[1]));
            Members.Add("3", new MultiClubMember("3", "Alice Johnson"));
            Members.Add("4", new MultiClubMember("4", "Bob Brown"));
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
        Console.WriteLine("Welcome to X Fitness Center. What would you like to do?");
        Console.WriteLine("______________________________________________________");
        Console.WriteLine("1. Add member");
        Console.WriteLine("2. Renove member");
        Console.WriteLine("3. Check in");
        Console.WriteLine("4. Check out");
        Console.WriteLine("5. Display member info");
        Console.WriteLine("6. Check balance");
        Console.WriteLine("7. Exit");
        Console.WriteLine(" ");
        Console.WriteLine("Please type the # of the action you wish to take.");

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
