using HotChocolate;

namespace StockApi.Models;

public class Stock
{
    public int Id { get; set; }

    public string Symbol { get; set; } = string.Empty;

    public string Company { get; set; } = string.Empty;

    public decimal Price { get; set; }

    public int PortfolioId { get; set; }
    public Portfolio Portfolio { get; set; } = null!;
}



[ExtendObjectType<Stock>]
public class StockExtensions
{
    public string DisplayName([Parent] Stock stock)
    {
        return $"{stock.Symbol} - {stock.Company}";
    }
}