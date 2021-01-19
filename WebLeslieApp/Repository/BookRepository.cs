using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLeslieApp.Models;

namespace WebLeslieApp.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC",Author="Leslie",Description="This is the description for MVC book",Category="Program",Language="English",TotalPages=1023},
                new BookModel(){Id=2,Title="C#",Author="Leslie",Description="This is the description for C# book",Category="Teach",Language="Chinese",TotalPages=193},
                new BookModel(){Id=3,Title="Java",Author="Catherian",Description="This is the description for JAVA book",Category="Develop",Language="English",TotalPages=860},
                new BookModel(){Id=4,Title="Javascript",Author="Catherina",Description="This is the description for Javascript book",Category="Lanch",Language="English",TotalPages=683}
            };
        }
    }
}
