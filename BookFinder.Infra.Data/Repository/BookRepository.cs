using BookFinder.Domain.Interfaces;
using BookFinder.Domain.Models;
using BookFinder.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
        public void AddBook(Book NewBook)
        {
            _ctx.Books.Add(NewBook);
            _ctx.SaveChanges();
        }
        public List<Book> GetSearchResult(string keyword)
        {

            var reqBook = _ctx.Books.Where(b => b.name.Contains(keyword) || b.author.Contains(keyword)).ToList();
            
            return reqBook;
        }

    }
}
