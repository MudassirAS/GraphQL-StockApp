using Microsoft.EntityFrameworkCore;
using StockApi.Data;
using StockApi.Models;
using HotChocolate.Data;

namespace StockApi.GraphQL;

public class Query
{
    [UsePaging]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Stock> GetStocks(AppDbContext context)
    {
        return context.Stocks;
    }

    public IQueryable<Stock> GetStock(AppDbContext context)
    {
        return context.Stocks;
    }


    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Portfolio> GetPortfolios(AppDbContext context)
    {
        return context.Portfolios;
    }
}