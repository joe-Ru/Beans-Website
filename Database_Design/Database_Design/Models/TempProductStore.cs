using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_Design.Models
{
    public class TempProductStore : IProductRepository
    {
        public IEnumerable<Product> Products => new List<Product> {
        new Product {Name = "Troll", Price = 25, Description = "Small hairy troll from the souther region of Qualll."},
        new Product {Name = "Young Troll", Price = 15, Description = "Young hairy troll from the mid region of Qualll."},
        new Product {Name = "Old Troll", Price = 35, Description = "Old hairy troll from the northern region of Qualll."}
            };
    }
}
