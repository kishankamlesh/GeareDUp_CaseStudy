using BookFinder.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookFinder.Application.ViewModels
{
    public class SearchBookViewModel
    {
        public List<Book> SearchedBooks { get; set; }
    }
}
