using BookFinder.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookFinder.Apllication.ViewModels
{
    public class BookViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
