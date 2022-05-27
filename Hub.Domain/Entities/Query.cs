namespace Hub.Domain.Enties;

public class Query
{
    public long HotelId { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }

    public int Guest { get; set; }

    public int Rooms { get; set; }

    public string? Currency { get; set; }
}