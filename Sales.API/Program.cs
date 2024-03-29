using Microsoft.EntityFrameworkCore;
using Sales.Infraestructure.context;
using Sales.Infraestructure.DataSeeding;
using Sales.IOC.NegocioDependencies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<SalesContext>(o => o
                .UseSqlServer(builder.Configuration.GetConnectionString("Sales")));

builder.Services.AddDependency();

await Seeding.Seed(builder.Services.BuildServiceProvider());

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
