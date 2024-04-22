using Albuns.API.Infra.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
var connectionString = builder.Configuration.GetConnectionString("Sqlite");

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AlbunsDbContext>(opt => opt.UseSqlite(connectionString));

builder.Services.AddGraphQLServer().AddQueryType<Query>()
                                   .AddProjections()
                                   .AddFiltering()
                                   .AddSorting();
var app = builder.Build();

CreateDatabase(app);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGraphQL("/graphql");

app.Run();

static void CreateDatabase(WebApplication app)
{
    var serviceScope = app.Services.CreateScope();
    var dataContext = serviceScope.ServiceProvider.GetService<AlbunsDbContext>();
    dataContext?.Database.EnsureCreated();
}