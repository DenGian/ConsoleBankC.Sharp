namespace BankAccount;

public class Account
{
public enum Type 
{
checkingsAccount, 
savingsAccount
}
    public Client client;
    public int balance = 0;
    public Type type;

public Account(Client client, int balance, int type) {
this.balance += balance;
this.client = client;
this.type = typeSelector(type);
}
public Type typeSelector(int selector)
{
if(selector == 1)
{
return type = Type.checkingsAccount;
}
else if (selector == 2)
{
return type = Type.savingingsAccount;
}
else
{
return type = Type.checkingsAccount;
}
public int checkBalance()
{
return this.balance;
}
public int withdraw(int amountWithdraw)
{
if (amount<=0)
{
throw new Exception("You need to have a positive number please.");
}
if (this.balance - amount < 0)
{
throw new Exception("You don't have sufficient funds");
}
return this.balance -= amount;
}
public int Deposit (int amount)
{
if (amount <= 0) 
{
throw new Exception("Amount has to be more than +0");
}
return this.balance += amount;
}
}
}