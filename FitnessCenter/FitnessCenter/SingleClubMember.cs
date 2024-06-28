
namespace FitnessCenter;

public class SingleClubMember : Member
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
