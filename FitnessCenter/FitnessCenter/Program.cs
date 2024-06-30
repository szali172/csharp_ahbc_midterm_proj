using FitnessCenter;

static void Main() 
{
    Club club = new Club("Test Club", "123 North Street");
    SingleClubMember member = new SingleClubMember(club, "Test Member", "id123");
    MultiClubMember member2 = new MultiClubMember("Person Member", "id234");

    // Create a dictionary of members
    Dictionary<string, Member> members = new Dictionary<string, Member>()
    {
        { member.ID, member },
        { member2.ID, member2 },
    };

    // Create a list of clubs
    List<Club> clubs = new List<Club> { club };

    // Initialize the UI with members and clubs
    UI ui = new UI(members, clubs);

    // Directly call RemoveMemberScreen method
    ui.MainPage();

    // Keep the console open to view results
    Console.WriteLine("Press any key to exit...");
    Console.ReadKey();

}

Main();


