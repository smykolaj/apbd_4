using Microsoft.AspNetCore.Http.HttpResults;
using VeterinaryShelter.Database;
using VeterinaryShelter.Endpoints;
using VeterinaryShelter.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


//Minimal API
app.MapAnimalsEndpoints();



//Controllers
//app.MapControllers();

app.Run();

