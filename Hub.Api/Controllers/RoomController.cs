using Microsoft.AspNetCore.Mvc;
using Hub.Domain.Services;
using Hub.Api.Dto;

namespace Hub.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RoomController : ControllerBase
{
    private readonly ILogger<RoomController> _logger;
    private readonly IHotelService _hotelService;

    public RoomController(IHotelService service, ILogger<RoomController> logger)
    {
        _hotelService = service;
        _logger = logger;
    }

    [HttpPost]
    public async Task<Response> SearchRooms(QueryDTO query)
    {
        var queryResult = await _hotelService.GetRooms(query.ToDomain());
        return new Response()
        {
            Rooms = queryResult.Select(x => x.ToDTO())
        };
    }
}
