using System.ComponentModel.DataAnnotations;

namespace Hub.Api.Dto;

public class QueryDTO
{
    [Required]
    public long HotelId { get; set; }

    [Required]
    public DateTime CheckIn { get; set; }

    [Required]
    public DateTime CheckOut { get; set; }

    [Required]
    public int Guest { get; set; }

    [Required]
    public int Rooms { get; set; }

    [Required]
    public string? Currency { get; set; }
}