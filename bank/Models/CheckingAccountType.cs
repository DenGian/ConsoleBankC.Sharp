using System.Diagnostics;

namespace CheckingAccountType.Models;

public sealed class CheckingAccountType
{
    private static readonly CheckingAccount instance = new CheckingAccountType();
    static CheckingAccount()
    {
        
    }
    private CheckingAccount()
    {
        
    }
    public static CheckingAccount Instance
    {
        get
        {
            return instance;
        }
    }
    public static void ChoiceConfirmation()
    {
        
    }
}