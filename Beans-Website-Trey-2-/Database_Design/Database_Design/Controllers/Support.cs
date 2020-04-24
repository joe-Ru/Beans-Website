using Microsoft.AspNetCore.Mvc;

namespace Database_Design.Controllers
{
    public class Support : Controller
    {
        // GET
        public IActionResult TechSupport()
        {
            return View();
        }
        public IActionResult ReportContent()
        {
            return View();
        }
        public IActionResult MessageCreator()
        {
            return View();
        }
    }
}