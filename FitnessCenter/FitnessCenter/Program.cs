using FitnessCenter;

static void Main() 
{
    // Initialize clubs and members
    Club club1 = new Club("Club 1", "123 North Street");
    Club club2 = new Club("Club 2", "456 South Street");
    List<Club> clubs = new List<Club> { club1, club2 };

    SingleClubMember member1 = new SingleClubMember(club1, "John Doe", "1");
    MultiClubMember member2 = new MultiClubMember("Jane Smith", "2");

    Dictionary<string, Member> members = new Dictionary<string, Member>
            {
                { member1.ID, member1 },
                { member2.ID, member2 }
            };

    UI ui = new UI(members, clubs);

    // Simulate UI interaction
    ui.MainPage();
}
Main();

