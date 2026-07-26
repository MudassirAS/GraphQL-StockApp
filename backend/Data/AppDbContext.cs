using Microsoft.EntityFrameworkCore;
using StockApi.Models;

namespace StockApi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {        
    }
    
    public DbSet<Stock> Stocks => Set<Stock>();
    public DbSet<Portfolio> Portfolios => Set<Portfolio>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Portfolio>().HasData(
            new Portfolio
            {
                Id = 1,
                Name = "Tech Portfolio"
            },
            new Portfolio
            {
                Id = 2,
                Name = "Growth Portfolio"
            }
        );

        modelBuilder.Entity<Stock>().HasData(
            new Stock
            {
                Id = 1,
                Symbol = "AAPL",
                Company = "Apple",
                Price = 210.45m,
                PortfolioId = 1
            },
            new Stock
            {
                Id = 2,
                Symbol = "MSFT",
                Company = "Microsoft",
                Price = 520.35m,
                PortfolioId = 1
            },
            new Stock
            {
                Id = 3,
                Symbol = "AMD",
                Company = "Advanced Micro Devices",
                Price = 182.65m,
                PortfolioId = 2
            },
            new Stock
            {
                Id = 4,
                Symbol = "NVDA",
                Company = "NVIDIA",
                Price = 178.20m,
                PortfolioId = 2
            }
        );
    }
}