using Microsoft.EntityFrameworkCore;
using StockApi.Data;
using StockApi.Models;
using HotChocolate.Data;

namespace StockApi.GraphQL;

public class Query
{
    public async Task<List<Stock>> GetStocks(AppDbContext context)
    {
        return await context.Stocks.ToListAsync();
    }

    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Stock> GetStock(
        AppDbContext context
    )
    {
        return context.Stocks;
    }
}