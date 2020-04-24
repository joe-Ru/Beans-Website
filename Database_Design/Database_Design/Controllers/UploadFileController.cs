using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Database_Design.Controllers
{
    public class UploadFileController : Controller
    {
        // GET: UploadFileController1
        public ActionResult UploadFilePage()
        {
            return View();
        }

        // GET: UploadFileController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UploadFileController1/Create   
        [HttpPost("UploadFile")]
        public ActionResult UploadFile(IFormCollection collection)
        {
            try
            {
                string ImageUrl = collection["ImageUrl"];
                string ProductName = collection["ProductName"];

                Console.WriteLine(ImageUrl, ProductName);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("UploadFile");
            }
        }

        // GET: UploadFileController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UploadFileController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UploadFileController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UploadFileController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}