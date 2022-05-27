namespace Hub.Infra.Implementation.External;

using Hub.Data.External;
using Hub.Data.External.Entities;

public class HotelLegAPI : IHotelLegsAPI
{
    public Task<Result> Search(QueryData query) => Task.FromResult(new Result
    {
        Results = new List<RoomData>
        {
            new RoomData(){
                CanCanel= true,
                Meal = 1,
                Price = 132.3M,
                Room = 1

            },
            new RoomData(){
                CanCanel= true,
                Meal = 2,
                Price = 142.3M,
                Room = 2

            },
            new RoomData(){
                CanCanel= true,
                Meal = 3,
                Price = 142.3M,
                Room = 3

            }
        }
    });

}
