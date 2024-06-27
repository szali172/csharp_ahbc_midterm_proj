namespace FitnessCenter;

public class MultiClubMember : Member
{
    private int MembershipPoints { get; set; }

    public MultiClubMember(string name, string id)
    {
        Fees = 15.00m;
        MembershipPoints = 0;
    }


    public override void CheckIn(Club club)
    {
        throw new NotImplementedException();
        //club.CheckedIn_Members.Add(this);
    }

    public override void CheckOut(Club club)
    {
        throw new NotImplementedException();
        //club.CheckedOut_Members.Remove(this);
    }

}
