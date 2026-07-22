using Microsoft.EntityFrameworkCore;
using StockApi.Data;
using StockApi.Models;

namespace StockApi.GraphQL;

public class Query
{
    public async Task<List<Stock>> GetStocks(AppDbContext context)
    {
        return await context.Stocks.ToListAsync();
    }

    public async Task<Stock?> GetStock(
        int id,
        AppDbContext context
    )
    {
        return await context.Stocks
            .FirstOrDefaultAsync(s => s.Id == id);
    }
}