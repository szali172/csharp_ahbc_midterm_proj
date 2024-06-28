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

    public override void CheckIn(Club club)
    {
        MembershipPoints += 5;
        club.CheckedInMembers.Add(this);
    }

    public override void CheckOut(Club club)
    {
        club.CheckedInMembers.Remove(this);
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
