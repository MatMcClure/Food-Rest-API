using BuberBreakfast.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);
{
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IBreakfastService, BreakfastService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
}

var app = builder.Build();
{
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
}