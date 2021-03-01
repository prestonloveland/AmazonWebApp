/*
 * Preston Loveland
 * Assignment 5
 * Section 1 Group 11
 * */
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazonWebApp.Models;

//class to create view componenet to add to a Razr page (shared.cshtml) 
//callable by vc:navigation-menu
namespace AmazonWebApp.Components
{
    public class NavigationMenuViewComponent : ViewComponent 
    {
        private IAmazonRepository _repository;

        public NavigationMenuViewComponent (IAmazonRepository repo)
        {
            _repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["category"];

            return View(_repository.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
