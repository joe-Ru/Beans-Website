using Database_Design.Models;

namespace Database_Design.Models.ViewModels
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }

        public string ReturnUrl { get; set; }
    }
}