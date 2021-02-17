/*
 * Preston Loveland
 * Assignment 5
 * Section 1 Group 11
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonWebApp.Models
{
    public class EFAmazonRepository : IAmazonRepository
    {
        private AmazonDbContext _context;

        //Constructor
        public EFAmazonRepository(AmazonDbContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
