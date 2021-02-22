/*
 * Preston Loveland
 * Assignment 5
 * Section 1 Group 11
 * */
using AmazonWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AmazonWebApp.Models.ViewModels;

namespace AmazonWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IAmazonRepository _repository;

        public int PageSize = 5;


        //sets the private repository to the variable that was passed
        public HomeController(ILogger<HomeController> logger, IAmazonRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        //returns view with the repository loaded with seeded books
        public IActionResult Index(int page = 1)
        {
            //allows the page to show only a certain number of entries
            return View(new BookListViewModel
            {
                Books = _repository.Books
                .OrderBy(b => b.BookId)
                .Skip((page - 1) * PageSize)
                .Take(PageSize)
                ,
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalNumItems = _repository.Books.Count()
                }
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
