using StockApi.GraphQL.Inputs;
using StockApi.Models;

namespace StockApi.GraphQL;

public class Mutation
{
    public Stock CreateStock(CreateStockInput input)
    {
        return new Stock
        {
            Id = Random.Shared.Next(1, 1000),
            Symbol = input.Symbol,
            Company = input.Company,
            Price = input.Price
        };
    }
}