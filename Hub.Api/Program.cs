using Hub.Domain.Services;
using Hub.Data.External;
using Hub.Infra.Implementation.External;
using Hub.Infra.Implementation.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IHotelLegsAPI, TravelDoorXAPI>();
builder.Services.AddSingleton<IHotelLegsAPI, HotelLegAPI>();
builder.Services.AddSingleton<IHotelService, HotelService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
