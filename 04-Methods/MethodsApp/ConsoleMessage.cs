namespace DefaultNamespace;

public class ConsoleMessage
{
    public static void SayHello(string firstName)
    {
        Console.WriteLine($"Hello {firstName}");
        Console.WriteLine("i hope you are having a good day .");
    }

    // Tuples :
    public static (string firstName, string lastName) GetUserName()
    {
        Console.Write("What is your firstName :");
        string firstName = Console.ReadLine();
        
        Console.Write("What is your lastName :");
        string lastName = Console.ReadLine();

        return (firstName , lastName);
    }

    public static void SayGoodbye()
    {
        Console.WriteLine("I hope you are having a good day .");
        Console.WriteLine("Thank you for visiting .");
    }
}