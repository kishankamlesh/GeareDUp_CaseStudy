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
    public class AddBookController : Controller
    {
        
        public IAddBook _addBook;
        public AddBookController(IAddBook addBook)
        {
            _addBook = addBook;
            
        } 
        public IActionResult AddPage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(Book newBook)
        {
            _addBook.AddBook(newBook);
            return RedirectToAction("Library", "Library");
        }
    }
}
