using BookFinder.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookFinder.Application.Interfaces
{
    public interface ISearchBook
    {
        SearchBookViewModel GetSearchResult(string keyword);
    }
}
