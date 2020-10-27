using BookFinder.Domain.Models;
using BookFinder.Infra.Data.Context;
using BookFinder.Infra.Data.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BookFinder.UnitTest
{
    [TestClass]
    public class RepositoryTest
    {
        private BookDBContext _ctx;
        public void BookRepository(BookDBContext ctx)
        {
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
    }
}
