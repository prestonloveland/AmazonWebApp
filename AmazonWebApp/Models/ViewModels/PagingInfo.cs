/*
Preston Loveland
Assignment 5
Section 1 Group 11*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//class to get information on page number to leave in other places
namespace AmazonWebApp.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalNumItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)(Math.Ceiling((decimal)TotalNumItems / ItemsPerPage));
    }
}
