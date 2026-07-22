using Microsoft.EntityFrameworkCore;
using StockApi.Models;

namespace StockApi.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) 
    : DbContext(options)
{
    
    public DbSet<Stock> Stocks => Set<Stock>();
}