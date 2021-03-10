/*
 * Preston Loveland
 * Assignment 8
 * Section 1 Group 11
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazonWebApp.Infrastructure;
using AmazonWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AmazonWebApp.Pages
{
    //class associated with page to help wiht cart
    public class BuyModel : PageModel
    {
        private IAmazonRepository _repository;

        //Constructor
        public BuyModel (IAmazonRepository repo, Cart cartService)
        {
            _repository = repo;
            Cart = cartService;
        }

        //Attributes
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }

        //Methods
        public void OnGet(string returnUrl)
        {
            //set Return url to whats been set in or to / if null
            ReturnUrl = returnUrl ?? "/";
           // Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = _repository.Books.FirstOrDefault(book => book.BookId == bookId);

           // Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(book, 1);

           // HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }

        public IActionResult OnPostRemove (long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl => cl.Book.BookId == bookId).Book);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
