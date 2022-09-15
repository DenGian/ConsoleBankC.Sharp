// Using classes
using BankAccount;
using ClientAccount;
// variables
string? name = "";
string? initialBalance = "";
string? typeSelection = "";
DateTime currentDate = DateTime.Now;
string? actionSelection = "";
string? confirmation = "";
int time = currentDate.Hour;
int[] day = { 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
// Stating the current date and time
Console.WriteLine("The current date and hour is: " + DateTime.Now + ".");
// Asking customer name
Thread.Sleep(500);
Console.WriteLine("Who am I helping this fabulous day?");
if (string.IsNullOrEmpty(name))
{
    name = Console.ReadLine();
}
// Checking time and greeting customer
Thread.Sleep(500);
Console.WriteLine(day.Contains(time)
    ? "Good day " + name + ", what action would you like to perform? "
    : "Good night, what action would you like to perform? ");
// Choosing type of account
if (name is not null)
{
    Client client = new Client(1, name, currentDate);
    Thread.Sleep(1000);
    Console.WriteLine("Please enter '1' for a Checking Account");
    Thread.Sleep(1000);
    Console.WriteLine("Please enter '2' for a Savings Account");

    typeSelection = Console.ReadLine();
    Console.WriteLine("You chose for a " + typeSelection + ".");
    Thread.Sleep(1000);
    Console.WriteLine("Please type '1' to confirm your choice.");
    Thread.Sleep(1000);
    Console.WriteLine("Please type '2' if you would like to change your choice.");
    confirmation = Console.ReadLine();
    if (confirmation != null && confirmation.Contains("2"))
    {
        
    }
    else if (confirmation == null)
    {
        Console.WriteLine("Please, confirm your choice");
    }
}
// Initial deposit
Console.WriteLine("How much would you like to deposit in this account?");
if (string.IsNullOrEmpty(initialBalance))
{
    initialBalance = Console.ReadLine();
}
// Creating the account
// if (typeSelection != null && initialBalance != null)
// {
//     BankAccount Account = new BankAccount(int.Parse(initialbalance), client, int.Parse(typeselection));
// }