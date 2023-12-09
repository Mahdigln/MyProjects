using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace InfraStructure;

public class DbContextClass : DbContext
{
    public DbContextClass(DbContextOptions<DbContextClass> contextOptions) : base(contextOptions)
    {

    }

    public DbSet<ProductDetails> Products { get; set; }
}