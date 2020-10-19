using BookFinder.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookFinder.Domain.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
    }
}
