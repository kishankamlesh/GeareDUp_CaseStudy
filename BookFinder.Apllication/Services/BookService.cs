using BookFinder.Apllication.Interfaces;
using BookFinder.Apllication.ViewModels;
using BookFinder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookFinder.Apllication.Services
{
    public class BookService : IBookService
    {
        private IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public IEnumerable<BookViewModel> GetBooks()
        {
            throw new NotImplementedException();
        }
    }
}
