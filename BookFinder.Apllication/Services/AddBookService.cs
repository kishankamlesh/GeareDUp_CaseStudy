using BookFinder.Application.Interfaces;
using BookFinder.Domain.Interfaces;
using BookFinder.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookFinder.Application.Services
{
    public class AddBookService : IAddBook
    {
        private IBookRepository _bookRepository;

        public AddBookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public bool AddBook(Book newBook)
        {
            bool status = _bookRepository.AddBook(newBook);
            return status;
        }
    }
}
