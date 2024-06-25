
namespace FitnessCenter;
abstract class Member
{
    //properties
    private string ID { get; set; }
    private string Name { get; set; }
    private decimal Fees { get; set; }
    //methods
    public abstract void CheckIn(Club);
    
    public abstract void CheckOut(Club);
    
}
