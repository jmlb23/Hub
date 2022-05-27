namespace Hub.Api.Dto;

public class RateDTO
{
    public int MealId { get; set; }
    public bool IsCancelled { get; set; }
    public decimal Price { get; set; }
}