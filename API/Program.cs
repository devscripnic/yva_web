var builder = WebApplication.CreateBuilder(args);

// Register controller support
builder.Services.AddControllers();

var app = builder.Build();

// Connecting controller routing
app.MapControllers();


app.Run();