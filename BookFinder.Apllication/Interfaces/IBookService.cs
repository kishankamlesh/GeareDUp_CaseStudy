using BookFinder.Apllication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookFinder.Apllication.Interfaces
{
    public interface IBookService
    {
        IEnumerable<BookViewModel> GetBooks();
    }
}
