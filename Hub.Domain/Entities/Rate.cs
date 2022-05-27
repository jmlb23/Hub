namespace Hub.Domain.Enties;

public class Rate
{
    public int MealId { get; set; }
    public bool IsCancelled { get; set; }
    public decimal Price { get; set; }
}