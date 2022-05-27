namespace Hub.Domain.Services;

using Hub.Domain.Enties;

public interface IHotelService
{
    Task<IEnumerable<Room>> GetRooms(Query query);
}