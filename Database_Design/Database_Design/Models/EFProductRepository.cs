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
    }
}
