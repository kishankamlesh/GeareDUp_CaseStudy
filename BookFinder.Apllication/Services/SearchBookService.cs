using BookFinder.Application.Interfaces;
using BookFinder.Application.ViewModels;
using BookFinder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookFinder.Application.Services
{
    public class SearchBookService : ISearchBook
    {
        private IBookRepository _bookRepository;

        public SearchBookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public SearchBookViewModel GetSearchResult(string keyword)
        {
            return new SearchBookViewModel()
            {
                SearchedBooks = _bookRepository.GetSearchResult(keyword)
            };
        }
    }
}
