using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database_Design.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Database_Design.Controllers
{
    public class UploadFileController : Controller
    {
        //public static UploadFilePage FileList = new UploadFilePage();
        public IActionResult UploadFile()
        {
            return View();
        }


        // POST: UploadFileController1/Create   
        [HttpPost]
        public IActionResult getfile(string ImageUrl, string ProductName)
        {
            try
            {
             

                Console.WriteLine(ImageUrl, ProductName);
                //return RedirectToAction(nameof(Index));
                return Content(ImageUrl);            
            }
            catch
            {
                return View("UploadFile");
            }
        }
    }
}