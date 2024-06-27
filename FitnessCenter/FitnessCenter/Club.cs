namespace FitnessCenter;

public class Club
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Member> CheckedInMembers { get; set; }

    public Club(string name, string address)
    {
        Name = name;
        Address = address;
        CheckedInMembers = new List<Member>();
    }

    public void DisplayMemberInfo(Member member)
    {
        Console.WriteLine($"ID: {member.ID}, Name: {member.Name}");
    }

    public void AddMember(Member member)
    {
        CheckedInMembers.Add(member);
    }

    public void RemoveMember(Member member)
    {
        CheckedInMembers.Remove(member);
    }

    public decimal GenerateFees(Member member)
    {
        if (member is MultiClubMember)
        {
            return 15.0m;
        }
        else
        {
            return 10.0m;
        }
    }
}