using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Database_Design.Models;
using Database_Design.Models.ViewModels;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Database_Design.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int PageSize = 50;
        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }
        public ViewResult List(string category, int page = 1) => View(new ProductListViewModel { Products = repository.Products.Where(p => category == null || p.CategoryId == category).OrderBy(p => p.ProductId).Skip((page - 1) * PageSize).Take(PageSize), PagingInfo = new PagingInfo { CurrentPage = page, ItemsPerPage = PageSize, TotalItems = repository.Products.Count() }, CurrentCategory = category });
        
       // public ViewResult ProductDetails(int productID)
        //{
          //  var data = 
            //return View(data);
        //}
    }
}
