using BookFinder.Domain.Interfaces;
using BookFinder.Domain.Models;
using BookFinder.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

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
        public bool AddBook(Book newBook)
        {
            try
            {
                _ctx.Books.Add(newBook);
                _ctx.SaveChanges();
                return true;
            }
            catch(DbUpdateException ex)
            {
                if (ex.Entries.Count >= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                
            }
            
            
        }
        public List<Book> GetSearchResult(string keyword)
        {
            if (!(String.IsNullOrEmpty(keyword)))
            {
                var reqBook = _ctx.Books.Where(b => b.name.Contains(keyword) || b.author.Contains(keyword)).ToList();
                return reqBook;
            }

            else
            {
                return new List<Book>();
            }
            
        }

    }
}
