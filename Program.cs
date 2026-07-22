using Microsoft.EntityFrameworkCore;
using StockApi.Data;
using StockApi.GraphQL;

var builder = WebApplication.CreateBuilder(args);

// Register EF Core Services
builder.Services
    .AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(
            builder.Configuration.GetConnectionString("DefaultConnection")));

// Register GraphQL services
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
