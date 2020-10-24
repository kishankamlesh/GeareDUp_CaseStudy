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
        public void AddBook(Book NewBook)
        {
            _bookRepository.AddBook(NewBook);
        }
    }
}
