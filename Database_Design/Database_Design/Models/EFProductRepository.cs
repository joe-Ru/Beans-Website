using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database_Design.Models.Repositories;

namespace Database_Design.Models
{
    public class EFProductRepository :IProductRepository
    {
        private ApplicationDbContext context;
        public EFProductRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Product> Products => context.Products;

        public void SaveProduct(Product product) { if (product.ProductId == 0) { context.Products.Add(product); } else { Product dbEntry = context.Products.FirstOrDefault(p => p.ProductId == product.ProductId); if (dbEntry != null) { dbEntry.ProductName = product.ProductName; dbEntry.Description = product.Description; dbEntry.ProductPrice = product.ProductPrice; dbEntry.CategoryId = product.CategoryId; } } context.SaveChanges(); }
    }
}
