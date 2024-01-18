namespace MyApp;
// Note: actual namespace depends on the project name.

internal class Program
{
    private static void Main(string[] args)
    {
        var produto = new Product("Celular", 2000.0);

        produto.AddProduct(2);
        produto.AddProduct(2);
        produto.Info();
    }
}
