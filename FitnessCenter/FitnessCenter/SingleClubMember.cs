
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
        /*
         Check to see if its assigned to the passed club
         Otherwise throw exception
         If they’re at the right club, add this member to the passed in club’s CheckedIn_Members List property
         */
        assignedClub = club;
        throw new NotImplementedException();
    }
    public override void CheckOut(Club club)
    {
        throw new NotImplementedException();    
    }
    public void ChangeClub(Club newClub)
    {
        assignedClub = newClub;
    }
    public void ChangeMembership()
    {
        Console.WriteLine("Your club has changed");
    }
}
