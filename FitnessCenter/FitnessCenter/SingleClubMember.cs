
namespace FitnessCenter;

public class SingleClubMember : Member //come back to this
{
    //Properties
    public Club AssignedClub;

    //Constructor
    public SingleClubMember(Club assignedclub, string Name, string ID)
    {
        this.Name = Name;
        this.ID = ID;
        Fees = 10.00m;
        AssignedClub = assignedclub;
    }

    //Methods
    public override void CheckIn(Club club)
    {
        throw new NotImplementedException();
    }
    public override void CheckOut(Club club)
    {
        throw new NotImplementedException();    
    }
    public override void DisplayMemberInfo()
    {
        Console.WriteLine("\n==========================================");
        Console.WriteLine($"Name:\t\t{Name}");
        Console.WriteLine($"ID:\t\t{ID}");
        Console.WriteLine($"Fees:\t\t${Fees}");
        Console.WriteLine($"Club:\t\t{AssignedClub.Name} - ({AssignedClub.Address})");
        Console.WriteLine("==========================================\n");
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
