using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Database_Design.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCreator { get; set; }
        public string Description { get; set; }
        public  string ImageUrl { get; set; }
        public bool IsPreferred { get; set; }
        public string CategoryId { get; set; }
        
    }
}
