using MyApp.Entities.Enums;

namespace MyApp.Entities;

public class Order
{
    public int Id { get; set; }
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }

    public override string ToString()
    {
        return $"OrderId: {Id} | OrderDate: {Moment} | OrderStatus: {Status}";
    }
}
