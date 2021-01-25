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
        [ViewData]
        public string Title { get; set; }
        [ViewData]
        public BookModel Book { get; set; }
        public ViewResult Index()
        {
            Title = "Home Page from controller";
            Book = new BookModel() { Id = 55, Title = "This is test 55bookmodel" };
            return View();
        }

        public ViewResult AboutUs()
        {
            Title = "About Page from controller";
            return View();
        }

        public ViewResult ContactUs()
        {
            Title = "Contact Page from controller";
            return View();
        }
    }
}
