using Microsoft.EntityFrameworkCore;
using shiki_server.GraphQL;
using shiki_server.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ShikiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DateBaseShiki")));
builder.Services
    .AddGraphQLServer()
    //.AddFiltering()
    //.AddSorting()
    //.AddMutationType<Mutations>()
    .AddQueryType<Query>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
//app.UseAuthorization();


app.MapGraphQL();
app.MapControllers();

app.Run();
