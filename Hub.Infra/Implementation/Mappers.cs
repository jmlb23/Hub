namespace Hub.Infra.Implementation;

using Hub.Domain.Enties;
using Hub.Data.External.Entities;
public static class RoomMapper
{
    public static Room ToDomain(this RoomData roomData) => new Room
    {
        ID = roomData.Room,
        Rate = new Rate
        {
            IsCancelled = roomData.CanCanel,
            MealId = roomData.Meal,
            Price = roomData.Price
        }
    };
}

public static class QueryMapper
{
    public static QueryData ToData(this Query query) => new QueryData
    {
        CheckInDate = query.CheckIn,
        NumberOfNights = Convert.ToInt32((query.CheckIn - query.CheckOut).TotalDays),
        Currency = query.Currency,
        Guests = query.Guest,
        Hotel = query.HotelId,
        Rooms = query.Rooms
    };
}