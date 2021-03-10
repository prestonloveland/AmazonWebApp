/*
 * Preston Loveland
 * Assignment 8
 * Section 1 Group 11
 * */

using AmazonWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonWebApp.Components
{
    //class to help pass cart around
    public class CartSummaryViewComponent :ViewComponent
    {
        private Cart cart;

        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}
