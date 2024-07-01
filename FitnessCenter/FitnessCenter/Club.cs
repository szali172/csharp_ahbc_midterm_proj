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
        return member.Fees;
    }

    public void DisplayCheckedInMembers()
    {
        Console.WriteLine("=================================");
        if (CheckedInMembers.Count == 0)
        {
            Console.WriteLine("There are no members currently checked in at this club");
        }
        else
        {
            Console.WriteLine($"Members checked in at \"{Name}\":");
            for (int i = 0; i < CheckedInMembers.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}. {CheckedInMembers[i].Name}");
            }
        }
        Console.WriteLine("=================================");

    }
}