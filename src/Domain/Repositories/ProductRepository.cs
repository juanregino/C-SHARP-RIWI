using C__RIWI.src.Domain.Entities;
using C__RIWI.src.Domain.Repositories.Abstract_Repositories;
using Microsoft.EntityFrameworkCore;

namespace C__RIWI.src.Domain.Repositories
{

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
   public ProductRepository(AppDBContext context) : base(context)
   {}
}
}