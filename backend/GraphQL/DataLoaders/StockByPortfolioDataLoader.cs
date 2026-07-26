using GreenDonut;
using Microsoft.EntityFrameworkCore;
using StockApi.Data;
using StockApi.Models;

namespace StockApi.GraphQL.DataLoaders;

public class StockByPortfolioDataLoader
    : GroupedDataLoader<int, Stock>
{
    private readonly IDbContextFactory<AppDbContext> _dbContextFactory;

    public StockByPortfolioDataLoader(
        IBatchScheduler batchScheduler,
        DataLoaderOptions options,
        IDbContextFactory<AppDbContext> dbContextFactory)
        : base(batchScheduler, options)
    {
        _dbContextFactory = dbContextFactory;
    }

    protected override async Task<ILookup<int, Stock>> LoadGroupedBatchAsync(
        IReadOnlyList<int> keys,
        CancellationToken cancellationToken)
    {
        await using var db = await _dbContextFactory.CreateDbContextAsync(cancellationToken);

        var stocks = await db.Stocks
            .Where(s => keys.Contains(s.PortfolioId))
            .ToListAsync(cancellationToken);

        return stocks.ToLookup(s => s.PortfolioId);
    }
}