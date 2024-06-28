namespace FitnessCenter;

public class InvalidClub : Exception
{
    public InvalidClub()
    {
    }

    public InvalidClub(string message)
        : base(message)
    {
    }

    public InvalidClub(string message, Exception inner)
        : base(message, inner)
    {
    }
}