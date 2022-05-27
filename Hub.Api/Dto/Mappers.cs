namespace Hub.Api.Dto;

using Hub.Api.Dto;
using Hub.Domain.Enties;


public static class QueryDTOMapper 
{
    public static Query ToDomain(this QueryDTO queryDTO) => new Query{
        CheckIn = queryDTO.CheckIn,
        CheckOut = queryDTO.CheckOut,
        Currency = queryDTO.Currency,
        Guest = queryDTO.Guest,
        HotelId = queryDTO.HotelId,
        Rooms = queryDTO.Rooms
    };
}

public static class RoomMapper
{
    public static RoomDTO ToDTO(this Room room) => new RoomDTO
    {
        ID = room.ID,
        Rate = new RateDTO
        {
            IsCancelled = room.Rate?.IsCancelled ?? false,
            MealId = room.Rate?.MealId ?? 0,
            Price = room.Rate?.Price ?? 0M
        }
    };
}