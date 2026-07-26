namespace StockApi.Models;

public class Portfolio
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public List<Stock> Stocks { get; set; } = [];
}