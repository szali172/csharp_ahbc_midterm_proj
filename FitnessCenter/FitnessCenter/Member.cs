
namespace FitnessCenter;
public abstract class Member
{
    //properties
    public string ID { get; set; }
    public string Name { get; set; }
    public decimal Fees { get; set; }

    //methods
    public abstract void CheckIn(Clubs club);
    
    public abstract void CheckOut(Clubs club);

    public abstract void DisplayMemberInfo();
    
}
