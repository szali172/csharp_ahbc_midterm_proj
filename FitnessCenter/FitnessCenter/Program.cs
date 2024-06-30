using FitnessCenter;

static void Main() 
{
    Club club = new Club("test", "123 North Street");
    SingleClubMember member = new SingleClubMember(club, "test", "id123");
    MultiClubMember member2 = new MultiClubMember("person", "id234");

    Dictionary<string, Member> members = new Dictionary<string, Member>()
    {
       {member.ID, member}
    };

    List<Club> clubs = new List<Club> { club };

    UI ui = new UI(members, clubs);

    ui.DisplayMemberInfo();
    /* Test UI functions here */
    ui.CheckBalance();  
    }
Main();

