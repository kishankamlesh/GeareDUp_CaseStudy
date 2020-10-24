using BookFinder.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookFinder.Application.Interfaces
{
    public interface IAddBook
    {
        void AddBook(Book NewBook);
    }
}
