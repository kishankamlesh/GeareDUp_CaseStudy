using BookFinder.Apllication.Interfaces;
using BookFinder.Apllication.Services;
using BookFinder.Application.Interfaces;
using BookFinder.Application.Services;
using BookFinder.Domain.Interfaces;
using BookFinder.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookFinder.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IAddBook, AddBookService>();

            //infra.Data layer
            services.AddScoped<IBookRepository, BookRepository>();

        }
    }
}
