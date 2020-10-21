using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookFinder.Apllication.Interfaces;
using BookFinder.Apllication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookFinder.Controllers
{
    public class BookController : Controller
    {
        private IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            BookViewModel model = _bookService.GetBooks();
            return View();
        }
    }
}
