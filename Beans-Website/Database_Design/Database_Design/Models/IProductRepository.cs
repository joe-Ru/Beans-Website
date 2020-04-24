using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_Design.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        public Product GetProductById(int id)
        {
            return Products.Where(x => x.ProductId == id).FirstOrDefault();
        }
    }
}
