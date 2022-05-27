namespace Hub.Infra.Implementation.Services;

using Hub.Domain.Services;
using Hub.Data.External;
using Hub.Domain.Enties;
using Hub.Data.External.Entities;

public class HotelService : IHotelService
{
    private IEnumerable<IHotelLegsAPI> externalServices;
    public HotelService(IEnumerable<IHotelLegsAPI> externalServices)
    {
        this.externalServices = externalServices;
    }
    public async Task<IEnumerable<Room>> GetRooms(Query query)
    {
        IEnumerable<Task<Result>> tasks = externalServices.Select(x => x.Search(query.ToData()));
        var searchs = await Task.WhenAll(tasks);
        return searchs.SelectMany(x => x.Results?.Select(x => x.ToDomain()) ?? new List<Room>());
    }
}