using FitnessCenter;

static void Main() 
{
    Clubs club = new Clubs("test", "123 North Street");
    SingleClubMember member = new SingleClubMember(club, "test", "id123");
    MultiClubMember member2 = new MultiClubMember("person", "newId");

    Dictionary<string, Member> members = new Dictionary<string, Member>()
    {
       {member.ID, member}
    };

    List<Clubs> clubs = new List<Clubs> { club };

    UI ui = new UI(members, clubs);

    ui.DisplayMemberInfo();
    /* Test UI functions here */
    //ui.RequestMember();
    }
Main();

