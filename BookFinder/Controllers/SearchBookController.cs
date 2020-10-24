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
        
        
        public SearchBookController()
        {
                        
        } 
        public IActionResult SearchPage()
        {
            return View();
        }
    }
}
