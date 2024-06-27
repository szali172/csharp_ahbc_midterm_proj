
namespace FitnessCenter;

public class SingleClubMember : Member //come back to this
{
    //Properties
    private Club assignedClub;

    //Constructor
    public SingleClubMember(Club assignedclub, string Name, string ID)
    {
        this.Name = Name;
        this.ID = ID;
    }

    //Methods
    public override void CheckIn(Club club)
    {
        assignedClub = club;
        throw new NotImplementedException();
    }
    public override void CheckOut(Club club)
    {
        throw new NotImplementedException();    
    }
    public void ChangeClub(Club newClub)
    {
        throw new NotImplementedException ();
    }
    public void ChangeMembership()
    {
        throw new NotImplementedException();
        //Console.WriteLine("Your club has changed");
    }
}
