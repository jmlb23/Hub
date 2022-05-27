namespace Hub.Infra.Implementation.External;

using Hub.Data.External;
using Hub.Data.External.Entities;

public class TravelDoorXAPI : IHotelLegsAPI
{
    public Task<Result> Search(QueryData query) => Task.FromResult(new Result
    {
        Results = new List<RoomData>
        {
            new RoomData(){
                CanCanel= true,
                Meal = 3,
                Price = 162.3M,
                Room = 10

            },
            new RoomData(){
                CanCanel= true,
                Meal = 5,
                Price = 152.3M,
                Room = 12

            },
            new RoomData(){
                CanCanel= true,
                Meal = 9,
                Price = 192.3M,
                Room = 9

            }
        }
    });

}
