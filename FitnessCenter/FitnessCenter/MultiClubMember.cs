namespace FitnessCenter;

public class MultiClubMember : Member
{
    private int MembershipPoints { get; set; }

    public MultiClubMember(string name, string id)
    {
        Name = name;
        ID = id;
        Fees = 15.00m;
        MembershipPoints = 0;
    }


    public override void CheckIn(Clubs club)
    {
        throw new NotImplementedException();
        //club.CheckedIn_Members.Add(this);
    }

    public override void CheckOut(Clubs club)
    {
        throw new NotImplementedException();
        //club.CheckedOut_Members.Remove(this);
    }
    public override void DisplayMemberInfo()
    {
        Console.WriteLine("\n=================================");
        Console.WriteLine($"Name:\t\t\t{Name}");
        Console.WriteLine($"ID:\t\t\t{ID}");
        Console.WriteLine($"Fees:\t\t\t${Fees}");
        Console.WriteLine($"Membership Points:\t{MembershipPoints} pts");
        Console.WriteLine("=================================\n");
    }

}
