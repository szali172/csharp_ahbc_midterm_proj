using FitnessCenter;

static void Main() 
{
    Club club = new Club("test", "testAddy");
    SingleClubMember member = new SingleClubMember(club, "test", "id123");

    Dictionary<string, Member> members = new Dictionary<string, Member>()
    {
       {member.ID, member}
    };

    List<Club> clubs = new List<Club> { club };

    UI ui = new UI(members, clubs);

    /* Test UI functions here */
    //ui.RequestMember();
    }
Main();

