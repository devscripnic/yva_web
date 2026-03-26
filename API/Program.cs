using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

// Register controller support
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "YVA API v1");
        c.RoutePrefix = "swagger";
    });
}

// Connecting controller routing
app.MapControllers();


app.Run();