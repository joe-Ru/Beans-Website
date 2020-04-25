using AutoMapper;
using EmailService;
using Database_Design.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Database_Design.Controllers
{
    public class MessageCreatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MessageCreator(MessageCreator em)
        {
            string to = em.To;
            string subject = em.Subject;
            string body = em.Body;

            MailMessage mm = new MailMessage();

            mm.To.Add(to);
            mm.Subject = subject;
            mm.Body = body;
            mm.From = new MailAddress("3dndemailsender@gmail.com");
            mm.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = true;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("3dndemailsender@gmail.com", "WeLikeDnd100!");
            smtp.Send(mm);

            ViewBag.message = "You have successfully emailed " + em.To + " successfully!";

            return View();
        }
    }
}