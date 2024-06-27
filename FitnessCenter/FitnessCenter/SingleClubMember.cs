
namespace FitnessCenter;

public class SingleClubMember : Member //come back to this
{
    private Club assignedClub;
    //methods
    public void SingleClub(Club assignedclub, string Name, string ID)
    {
        Name = Name;
        ID = ID;
    }
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
