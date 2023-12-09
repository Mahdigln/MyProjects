using Core.Interfaces;
using Core.Models;
using Core;

namespace InfraStructure.Repositories;

public class ProductRepository : GenericRepository<ProductDetails>, IProductRepository
{
    public ProductRepository(DbContextClass dbContext) : base(dbContext)
    {

    }
}