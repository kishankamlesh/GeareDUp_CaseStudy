using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookFinder.Apllication.Interfaces;
using BookFinder.Apllication.ViewModels;
using BookFinder.Application.Interfaces;
using BookFinder.Application.ViewModels;
using BookFinder.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookFinder.Controllers
{
    public class SearchBookController : Controller
    {
        private ISearchBook _searchBook;
        
        public SearchBookController(ISearchBook searchBook)
        {
            _searchBook = searchBook;
        } 
        public IActionResult SearchPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SearchBook(string keyword)
        {
            SearchBookViewModel model = _searchBook.GetSearchResult(keyword);
            return View(model);
        }
    }
}
