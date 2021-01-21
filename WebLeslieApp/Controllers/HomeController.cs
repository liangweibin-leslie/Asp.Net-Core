using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Dynamic;
using WebLeslieApp.Models;

namespace WebLeslieApp.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            ViewData["book"] = new BookModel() { Author = "Libai", Title = "Huanghe" };
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
