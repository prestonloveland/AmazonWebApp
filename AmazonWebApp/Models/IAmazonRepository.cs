/*
 * Preston Loveland
 * Assignment 5
 * Section 1 Group 11
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//base to inherit from in controller to set up a queryable with boook objects
namespace AmazonWebApp.Models
{
    public interface IAmazonRepository
    {
        IQueryable<Book> Books { get; }
    }
}
