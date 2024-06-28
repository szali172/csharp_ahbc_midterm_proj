
namespace FitnessCenter;
public abstract class Member
{
    //properties
    public string ID { get; set; }
    public string Name { get; set; }
    public decimal Fees { get; set; }

    //methods
    public abstract void CheckIn(Club club);
    
    public abstract void CheckOut(Club club);

    public abstract void DisplayMemberInfo();
    
}
