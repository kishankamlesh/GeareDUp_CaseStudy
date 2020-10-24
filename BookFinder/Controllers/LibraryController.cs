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
    public class LibraryController : Controller
    {
        private IBookService _bookService;
        public IAddBook _addBook;
        public LibraryController(IBookService bookService)
        {
            _bookService = bookService;
            
        }
        
        public IActionResult Library()
        {
            BookViewModel model = _bookService.GetBooks();
            return View(model);
        }        
    }
}
