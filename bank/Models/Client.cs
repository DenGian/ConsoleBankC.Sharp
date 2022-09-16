namespace ClientAccount;

public class Client
{
    // defining properties
    protected int Id;
    protected string Name;
    protected DateTime DateJoined;
    // constructor that takes multiple arguments
    public Client(int id, string name, DateTime dateJoined)
    {
        this.Id = id;
        this.Name = name;
        this.DateJoined = dateJoined;
    }
}