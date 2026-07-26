using StockApi.Data;
using StockApi.GraphQL.Inputs;
using StockApi.Models;

namespace StockApi.GraphQL;

public class Mutation
{
    public async Task<Stock> CreateStock(
        CreateStockInput input,
        AppDbContext context
    )
    {
        var stock = new Stock
        {
            Symbol = input.Symbol,
            Company = input.Company,
            Price = input.Price
        };

        context.Stocks.Add(stock);
        await context.SaveChangesAsync();
        return stock;  
    }
}