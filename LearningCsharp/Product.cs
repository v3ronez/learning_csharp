namespace MyApp;

public class Product
{
    public string Name;
    public double Price;
    public int Quantidy;

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public void AddProduct(int qtd)
    {
        Quantidy += qtd;
    }

    public void RemoveProduct(int qtd)
    {
        Quantidy -= qtd;
    }

    public double TotalValueStorate()
    {
        return Quantidy * Price;
    }

    public void Info()

    {
        Console.WriteLine($"Product info: {Name}, ${Price}, {Quantidy} qtds, Total: ${TotalValueStorate()}");
    }
}
