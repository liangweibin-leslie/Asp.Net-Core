using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WebLeslieApp.Enums;
using WebLeslieApp.Helpers;

namespace WebLeslieApp.Models
{
    public class BookModel
    {
        public int Id { get; set; }

        [StringLength(100,MinimumLength =3)]
        [Required(ErrorMessage ="Please enter the title of your book")]
        //[MyCustomValidation("mvc")]
        public string Title { get; set; }

        [Required(ErrorMessage ="Please enter the author name")]
        public string Author { get; set; }

        [StringLength(500,MinimumLength =10)]
        public string Description { get; set; }

        public string Category { get; set; }

        public int LanguageId { get; set; }
        public string Language { get; set; }

        [Required(ErrorMessage ="Please choose the languages of your book")]
        public LanguageEnum LanguageEnum { get; set; }

        [Required(ErrorMessage ="Please enter the pages")]
        [Display(Name ="Total pages of book")]
        public int TotalPages { get; set; }
    }
}
