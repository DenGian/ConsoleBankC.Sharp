namespace BankAccount;
using ClientAccount;

public class Account
{
    public enum Type
    {
        CheckingsAccount,
        SavingsAccount
    }

// defining properties
    protected Client client;
    protected int balance;
    protected Type type;

// constructor
    public Account(Client client, int balance, int type)
    {
        this.balance += balance;
        this.client = client;
        this.type = TypeSelector(type);
    }

//methods
    public Type TypeSelector(int selector)
    {
        if (selector == 1)
            return type = Type.CheckingsAccount;
        if (selector == 2)
            return type = Type.SavingsAccount;
        return type = Type.CheckingsAccount;
    }
    public int CheckBalance()
    {
        return balance;
    }
    public int Withdraw(int amountWithdraw)
    {
        if (amountWithdraw <= 0) throw new Exception("You need to have a positive number please.");
        if (balance - amountWithdraw < 0) throw new Exception("You don't have sufficient funds");
        return balance -= amountWithdraw;
    }

    public int Deposit(int amount)
    {
        if (amount <= 0) throw new Exception("Amount has to be more than +0");
        return balance += amount;
    }
}