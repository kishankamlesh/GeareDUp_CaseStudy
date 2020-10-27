using BookFinder.Domain.Models;
using BookFinder.Infra.Data.Context;
using BookFinder.Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookFinder.UnitTest
{
    [TestClass]
    public class RepositoryTest
    {
        public RepositoryTest()
        {
            InitContext();
        }
        private BookDBContext _ctx;
        public void InitContext()
        {
            var builder = new DbContextOptionsBuilder<BookDBContext>().UseSqlServer("Server=G3;Database=BookDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            var ctx = new BookDBContext(builder.Options);
            _ctx = ctx;
        }
        [TestMethod]
        public void AddBook_ReturnsTrue()
        {
            //Arrange
            var testBook = new BookRepository(_ctx);
            //Act
            var result = testBook.AddBook(new Book { isbn = "1234", name = "Demo", author = "Demo", publisher = "Demo", cost = 10, descriptuon = "Demo" });
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void AddBook_ReturnsFalse()
        {
            //Arrange
            var testBook = new BookRepository(_ctx);
            //Act
            var result = testBook.AddBook(new Book { isbn = "9781234567025", name = "Demo", author = "Demo", publisher = "Demo", cost = 10, descriptuon = "Demo" }); //adding an ISBN which already exists
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GetBooks_ReturnsList()
        {
            //Arrange
            var testBook = new BookRepository(_ctx);

            //Act
            var result = testBook.GetBooks();

            //Assert
            Assert.IsInstanceOfType(result, typeof(IEnumerable<Book>));
        }
        [TestMethod]
        public void GetSearchResults_ReturnsBook()
        {
            //Arrange
            var testBook = new BookRepository(_ctx);
            string keyword = "Harry";
            //Act
            var result = testBook.GetSearchResult(keyword);

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<Book>));
        }
        [TestMethod]
        public void GetSearchResults_ReturnsListOfBooks()
        {
            //Arrange
            var testBook = new BookRepository(_ctx);
            string keyword = "The";
            //Act
            var result = testBook.GetSearchResult(keyword);

            //Assert
            Assert.IsInstanceOfType(result, typeof(List<Book>));
        }
        [TestMethod]
        public void GetSearchResults_ReturnsEmptyList()
        {
            //Arrange
            var testBook = new BookRepository(_ctx);
            string keyword = "DemoBook";
            //Act
            var result = testBook.GetSearchResult(keyword);
            bool emptyListReturned;
            if (result.Count == 0)
            {
                emptyListReturned = true;
            }
            else
            {
                emptyListReturned = false;
            }
            //Assert
            Assert.IsTrue(emptyListReturned);
        }
    }
}
