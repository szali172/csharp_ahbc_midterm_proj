
namespace FitnessCenter;

public class SingleClubMember : Member
{
    //Properties
    private Club assignedClub;

    //Constructor
    public SingleClubMember(Club assignedclub, string Name, string ID)
    {
        this.Name = Name;
        this.ID = ID;
        Fees = 10.0m;
    }

    //Methods
    public override void CheckIn(Club club)
    {
        if (assignedClub == club)
        {
            club.CheckedInMembers.Add(this);
        }
        else 
        { 
            throw new InvalidClub("User not registered here, please try a diferent club"); 
        }
    }
    public override void CheckOut(Club club)
    {
        club.CheckedInMembers.Remove(this);
    }
    
}
