using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Database_Design.Models;

namespace UserController.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository repository;
        public UserController(IUserRepository repo)
        {
            repository = repo;
        }
        public ViewResult List() => View(repository.Users);
    }
}