﻿
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

            Members.Add("1", new SingleClubMember(Clubs[0], "John Doe", "1"));
            Members.Add("2", new SingleClubMember(Clubs[1], "Jane Smith", "2"));
            Members.Add("3", new MultiClubMember("Alice Johnson", "3"));
            Members.Add("4", new MultiClubMember("Bob Brown", "4"));
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
        
       try
        {
            Member member = RequestMember();
            Console.WriteLine($"Member \"{member.Name}\" checked in.");
        }
        catch (MemberNotFoundException) 
        {
        Console.WriteLine("Member not found. Return to menu.");
        }
    }

    public void CheckOutScreen()
    {

        try
        {
            Member member = RequestMember();
            Console.WriteLine($"Member \"{member.Name}\" checked out.");
        }
        catch (MemberNotFoundException)
        {
            Console.WriteLine("Member not found. Return to menu.");
        }
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
