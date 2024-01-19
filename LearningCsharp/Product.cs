namespace MyApp;

public class Product
{
    private readonly string _name;
    private int _quantidy;
    public double Price { get; private set; }

    public Product(string name, double price)
    {
        Price = price;
        _name = name;
    }


    public string GetName()
    {
        return _name;
    }

    public void AddProduct(int qtd)
    {
        SetQuantidy(qtd);
    }

    public void SetQuantidy(int qtd)
    {
        _quantidy = qtd;
    }

    public int GetQuantidy()
    {
        return _quantidy;
    }

    public void RemoveProduct(int qtd)
    {
        _quantidy -= qtd;
    }

    public double TotalValueStorate()
    {
        return _quantidy * Price;
    }

    public void Info()
    {
        Console.WriteLine($"Product info: {_name}, ${Price}, {_quantidy} qtds, Total: ${TotalValueStorate()}");
    }
}
