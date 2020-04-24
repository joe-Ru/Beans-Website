using Microsoft.AspNetCore.Mvc;
using Database_Design.Models;

namespace Database_Design.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart cartService) { cart = cartService; }

        public IViewComponentResult Invoke() { return View(cart); }
    }
}