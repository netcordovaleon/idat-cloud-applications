using idat.entities;
using Microsoft.EntityFrameworkCore;

namespace idat.domain;

public class MarketPlaceIdatDBContext : DbContext
{
    public MarketPlaceIdatDBContext(DbContextOptions<MarketPlaceIdatDBContext> options) : base(options)
    {
            
    }
    public DbSet<Product> ProductEntity { get; set; }



}
