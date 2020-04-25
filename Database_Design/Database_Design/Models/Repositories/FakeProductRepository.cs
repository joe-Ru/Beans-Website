using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database_Design.Models;

namespace Database_Design.Models.Repositories
{
    public class FakeProductRepository /* : IProductRepository*/
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product{ProductName ="Troll", ProductPrice= 15, Description ="Found deep in the hidden woods", ImageUrl = "", IsPreferred = true},
            new Product{ProductName ="Oger", ProductPrice= 13, Description ="lives in swamps", ImageUrl = "", IsPreferred = false},
            new Product{ProductName ="Wizard", ProductPrice= 16, Description ="They do magic learned through study", ImageUrl = "", IsPreferred = false},
            new Product{ProductName ="Blue Dice", ProductPrice= 5, Description ="these dice are blue", ImageUrl = "", IsPreferred = false}
        };

        public IEnumerable<Product> PreferredProduct { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
