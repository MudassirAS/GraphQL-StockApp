using StockApi.Models;

namespace StockApi.GraphQL;

public class Query
{
    private readonly List<Stock> _stocks =
    [
        new()
        {
            Id = 1,
            Symbol = "MSFT",
            Company = "Microsoft",
            Price = 520.35m
        },
        new()
        {
            Id = 2,
            Symbol = "AAPL",
            Company = "Apple",
            Price = 210.45m
        },
        new()
        {
            Id = 3,
            Symbol = "NVDA",
            Company = "NVIDIA",
            Price = 178.20m
        }
    ];

    public List<Stock> GetStocks() => _stocks;

    public Stock? GetStock(int id)
    {
        return _stocks.FirstOrDefault(s => s.Id == id);
    }
}