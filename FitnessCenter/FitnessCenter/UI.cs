using System.Text.RegularExpressions;

namespace FitnessCenter;

public class UI
{
    //Properties
    public Dictionary<string, Member> Members { get; set; }
    public List<Club> Clubs { get; set; }

    // Constructor
    public UI(Dictionary<string, Member> members, List<Club> clubs)
    {
        InitializeClubs(clubs);
        InitializeMembers(members);
    }

    // Methods
    private void InitializeClubs(List<Club> clubs)
    {
        if (clubs == null)
        {
            Clubs = new List<Club>
                {
                    new Club("Flex Appeal", "123 North Street"),
                    new Club("Git Gud", "456 South Street"),
                    new Club("Gym Jones", "789 West Street"),
                    new Club("Buff Buffet", "101 East Street")
                };
        }
        else
        {
            Clubs = clubs;
        }
    }

    private void InitializeMembers(Dictionary<string, Member> members)
    {
        if (members == null)
        {
            Members = new Dictionary<string, Member>
                {
                    { "1", new SingleClubMember(Clubs[0], "Morgan Jelly", "1") },
                    { "2", new SingleClubMember(Clubs[1], "20 Cent", "2") },
                    { "3", new SingleClubMember(Clubs[2], "Anita Bath", "3") },
                    { "4", new SingleClubMember(Clubs[2], "Brad Pitts", "4") },
                    { "5", new SingleClubMember(Clubs[2], "Captain Thanos", "5") },
                    { "6", new SingleClubMember(Clubs[3], "Jonathon GotHops", "6") },
                    { "7", new MultiClubMember("Betty White", "7") },
                    { "8", new MultiClubMember("Phil McCheese", "8") },
                    { "9", new MultiClubMember("Bigge No Smalls", "9") },
                    { "10", new MultiClubMember("Michael Blackbeard", "10") },
                };

            Members["1"].CheckIn(Clubs[0]);
            Members["2"].CheckIn(Clubs[1]);
            Members["3"].CheckIn(Clubs[2]);
            Members["4"].CheckIn(Clubs[2]);
            Members["5"].CheckIn(Clubs[2]);
            Members["6"].CheckIn(Clubs[3]);
            Members["7"].CheckIn(Clubs[0]);
            Members["8"].CheckIn(Clubs[1]);
            Members["9"].CheckIn(Clubs[1]);
            Members["10"].CheckIn(Clubs[3]);
        }
        else
        {
            Members = members;
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

    public Club ListClubs()
    {
        int choice;
        int minNumber = 1;
        int maxNumber = 4;
        while (true)
        {
            Console.WriteLine("Please select a club:");
            for (int i = 0; i < Clubs.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Clubs[i].Name}");
            }
            Console.WriteLine("Please enter the number of the club:");
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice >= minNumber && choice <= maxNumber)
                {
                    Console.WriteLine("Valid input: " + choice);
                    return Clubs[choice - 1];
                }
                else
                {
                    Console.WriteLine($"Input out of range. Please enter a number between {minNumber} and {maxNumber}.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }


    public Member RequestMember()
    {
        while (true)
        {
            Console.Write("Please enter a member ID: ");
            string memberID = Console.ReadLine();

            if (memberID == null)
            {
                Console.WriteLine("Please pass a valid input");
                continue;
            }

            else if (Members.ContainsKey(memberID))
            {
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
        while (true)
        {
            Console.WriteLine("\nWelcome to the GC Fitness Center. How can we help you today?");
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("1. Add Member");
            Console.WriteLine("2. Remove Member");
            Console.WriteLine("3. Check In Member");
            Console.WriteLine("4. Check Out Member");
            Console.WriteLine("5. Display Member Info");
            Console.WriteLine("6. Display Checked In Members");
            Console.WriteLine("7. Check Member Balance");
            Console.WriteLine("8. Exit");
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
                DisplayCheckInMembers();
            }
            else if (option == "7")
            {
                CheckBalance();
            }
            else if (option == "8")
            {
                Console.WriteLine("Exiting program...Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please type a number from 1 to 8.");
            }

        }
    }

    public void AddMemberScreen()
    {
        // Get the member name
        string name;
        while (true)
        {
            Console.Write("Enter the new member's name: ");
            string nameInput = Console.ReadLine();

            if (nameInput != null)
            {
                // Verify that the name is only letters
                if (Regex.IsMatch(nameInput, @"^[a-zA-Z]+$"))
                {
                    name = nameInput;
                    break;
                }
            }

            Console.WriteLine("The name you have entered is invalid. " +
                              "Please enter only letters for the name.");
        }

        // Get the member ID
        string ID;
        while (true)
        {
            Console.Write("Create a unique member ID: ");
            string IDInput = Console.ReadLine();

            if (IDInput != null)
            {
                if (IDInput.Length > 0 && CheckIfMemberExists(IDInput) == false)
                {
                    ID = IDInput;
                    break;
                }
            }

            Console.WriteLine("The ID you have entered is either invalid " +
                              "or already exists. Please try again");
        }

        // Get membership option
        string membership;

        while (true)
        {
            Console.WriteLine("Select a membership type (Enter \"1\" or \"2\"):");
            Console.WriteLine("\t1. Single Club Member");
            Console.WriteLine("\t2. Multi Club Member");
            string membershipInput = Console.ReadLine();

            if (membershipInput == "1")
            {
                membership = "Single";
                break;
            }
            else if (membershipInput == "2")
            {
                membership = "Multi";
                break;
            }

            Console.WriteLine("The value you have entered could not be read. " +
                              "Please enter either \"1\" or \"2\"");
        }

        // Create the member object, add it to members database
        if (membership == "Single")
        {
            Club selectedClub = ListClubs();  // Single club members only - Select a club
            SingleClubMember member = new SingleClubMember(selectedClub, name, ID);
            Members[ID] = member;
            Console.WriteLine($"Welcome \"{name}\"! Feel free to visit your club any time!\n");
        }
        else
        {
            MultiClubMember member = new MultiClubMember(name, ID);
            Members[ID] = member;
            Console.WriteLine($"Welcome \"{name}\"! Feel free to visit any of our clubs, any time!\n");
        }
    }

    public void RemoveMemberScreen()
    {
        Member memberToRemove = RequestMember();
        if (memberToRemove != null)
        {
            Club selectedClub = ListClubs();
            memberToRemove.CheckOut(selectedClub);
            Console.WriteLine($"Member {memberToRemove.Name} (ID: {memberToRemove.ID}) has been removed.");
            Console.WriteLine("Returning to main screen...");
            return;
        }
        else
        {
            Console.WriteLine("Member not found.");
        }
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

    public void CheckInScreen()
    {
        try
        {
            Member memberToCheckIn = RequestMember();
            Club selectedClub = ListClubs();
            memberToCheckIn.CheckIn(selectedClub);
            Console.WriteLine($"Member {memberToCheckIn.Name} has been checked in to {selectedClub.Name}.");
        }
        catch (InvalidClub ex)
        {
            Console.WriteLine(ex.Message);

            Console.Write("Press Enter to return back to the Main Menu");
            Console.ReadLine();
        }
        catch (MemberNotFoundException)
        {
            Console.WriteLine("Returning to main menu...");
        }
    }

    public void CheckOutScreen()
    {
        try
        {
            Member memberToCheckOut = RequestMember();
            Club selectedClub = ListClubs();
            memberToCheckOut.CheckOut(selectedClub);
            Console.WriteLine($"Member {memberToCheckOut.Name} has been checked out from {selectedClub.Name}.");
        }

        catch (MemberNotFoundException)
        {
            Console.WriteLine("Returning to main menu...");
        }
    }

    public void DisplayMemberInfo()
    {
        try
        {
            Member member = RequestMember();
            member.DisplayMemberInfo();

            Console.Write("Press Enter to return back to the Main Menu");
            Console.ReadLine();
        }
        catch (MemberNotFoundException) { }

    }

    public void DisplayCheckInMembers()
    {
        Console.WriteLine("Select a club you would like to view");
        Club selectedClub = ListClubs();

        selectedClub.DisplayCheckedInMembers();

        Console.Write("Press Enter to return back to the Main Menu");
        Console.ReadLine();
    }

    public void CheckBalance()
    {
        try
        {
            Member member = RequestMember();
            Console.WriteLine($"{member.Name}");
            Console.WriteLine($"${member.Fees}");
            if (member is MultiClubMember multiClubMember)
            {
                Console.WriteLine($"Points: {multiClubMember.MembershipPoints}");
            }
            else { }
            Console.Write("Press Enter to return back to the Main Menu");
            Console.ReadLine();
        }
        catch (MemberNotFoundException) { }
    }

}
