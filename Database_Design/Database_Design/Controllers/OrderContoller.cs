using Microsoft.AspNetCore.Mvc;
using Database_Design.Models;

namespace SportsStore.Controllers { 
    public class OrderController : Controller 
    { public ViewResult Checkout() => View(new Order()); 
    } 
}
