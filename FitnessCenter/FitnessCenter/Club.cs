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
    public List<Club> clubs = new List<Club>
    {
        //new Club { Name = "Club Choice A", Address = "1000 Monroe Blvd" },
        //new Club { Name = "Club Choice B", Address = "2000 Washington Ave" },
        //new Club { Name = "Club Choice C", Address = "3000 Maple St" }
    };
    public void ListClubs()
    {
        Console.WriteLine("List of Clubs:");
        foreach (var club in clubs)
        {
            Console.WriteLine($"Club Name: {club.Name}, Address: {club.Address}");
        }
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

}