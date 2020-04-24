using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database_Design.Models;

namespace Database_Design.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
