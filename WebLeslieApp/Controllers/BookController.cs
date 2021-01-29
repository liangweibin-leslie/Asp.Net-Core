using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebLeslieApp.Models;
using WebLeslieApp.Repository;

namespace WebLeslieApp.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController(BookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<ViewResult> GetAllBooks()
        {
            var data=await _bookRepository.GetAllBooks();
            return View(data);
        }

        public async Task<ViewResult> GetBook(int id)
        {
            var data = await _bookRepository.GetBookById(id);
            return View(data);
        }

        public List<BookModel> SearchBooks(string bookName,string authorName)
        {
            return _bookRepository.SearchBook(bookName,authorName);
        }

        public ViewResult AddNewBook(bool isSuccess = false, int bookId = 0)
        {
            var model = new BookModel()
            {
                //Language = "2"
            };
            //ViewBag.Language = GetLanguage().Select(x => new SelectListItem()
            //{
            //    Text = x.Text,
            //    Value = x.Id.ToString()
            //}).ToList();
            //var group1 = new SelectListGroup() { Name = "Group 1" };
            //var group2 = new SelectListGroup() { Name = "Group 2" ,Disabled=true};
            //var group3 = new SelectListGroup() { Name = "Group 3" };
            ViewBag.Language = new List<SelectListItem>()
            {
                new SelectListItem(){Text="English",Value="1"},
                new SelectListItem(){Text="Amerina",Value="2"},
                new SelectListItem(){Text="Chinese",Value="3"},
                new SelectListItem(){Text="Hindi",Value="4"},
                new SelectListItem(){Text="Japanese",Value="5"},
                new SelectListItem(){Text="Urbu",Value="6"}
            };
            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                int id = await _bookRepository.AddNewBook(bookModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddNewBook), new { isSuccess = true, bookId = id });
                }
            }
            ViewBag.Language = new List<SelectListItem>()
            {
                new SelectListItem(){Text="English",Value="1"},
                new SelectListItem(){Text="Amerina",Value="2"},
                new SelectListItem(){Text="Chinese",Value="3"},
                new SelectListItem(){Text="Hindi",Value="4"},
                new SelectListItem(){Text="Japanese",Value="5"},
                new SelectListItem(){Text="Urbu",Value="6"}
            };
            //ViewBag.IsSuccess = false;
            //ViewBag.BookId = 0;

            return View();
        }

        private List<LanguageModel> GetLanguage()
        {
            return new List<LanguageModel>()
            {
                new LanguageModel(){Id=1,Text="English"},
                new LanguageModel(){Id=2,Text="Chinese"},
                new LanguageModel(){Id=3,Text="Hindi"}
            };
        }
    }
}
