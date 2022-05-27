namespace Hub.Data.External;

using Hub.Data.External.Entities;
public interface IHotelLegsAPI
{
    Task<Result> Search(QueryData query);
}