using BookFinder.Domain.Interfaces;
using BookFinder.Domain.Models;
using BookFinder.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookFinder.Infra.Data.Repository
{
    public class BookRepository : IBookRepository
    {
        private BookDBContext _ctx;

        public BookRepository(BookDBContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Book> GetBooks()
        {
            return _ctx.Books;
        }
    }
}
