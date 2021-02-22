/*
Preston Loveland
Assignment 5
Section 1 Group 11*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//class to get list of books and information on page number
namespace AmazonWebApp.Models.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
