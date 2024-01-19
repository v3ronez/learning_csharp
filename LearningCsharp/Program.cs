namespace MyApp;
// Note: actual namespace depends on the project name.

internal class Program
{
    private static void Main(string[] args)
    {
        // var produto = new Product("Celular", 2000.0);
        //
        // produto.AddProduct(2);
        // produto.AddProduct(2);
        // produto.SetQuantidy(12);
        // produto.Info();

        Console.WriteLine("Welcome! Your accountNumber:");
        string accountNumber = Console.ReadLine();
        Console.WriteLine("Your name:");
        string accountName = Console.ReadLine();
        Console.WriteLine("Init deposit? ");
        bool initDeposit = bool.Parse(Console.ReadLine());

        Bank bank = new Bank(accountNumber, accountName);
    }
}
