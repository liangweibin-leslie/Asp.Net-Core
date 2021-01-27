using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
        public ViewResult GetAllBooks()
        {
            var data= _bookRepository.GetAllBooks();
            return View(data);
        }

        public ViewResult GetBook(int id,string nameOfBook)
        {
            dynamic data = new System.Dynamic.ExpandoObject();
            data.book = _bookRepository.GetBookById(id);
            data.Name = "Nitish"; 
            return View(data);
        }

        public List<BookModel> SearchBooks(string bookName,string authorName)
        {
            return _bookRepository.SearchBook(bookName,authorName);
        }

        public ViewResult AddNewBook()
        {
            return View();
        }

        [HttpPost]
        public ViewResult AddNewBook(BookModel bookModel)
        {
            _bookRepository.AddNewBook(bookModel);
            return View();
        }
    }
}
