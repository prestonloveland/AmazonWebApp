/*
 * Preston Loveland
 * Assignment 5
 * Section 1 Group 11
 * */
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonWebApp.Models
{
    //inherits from DBContext
    public class AmazonDbContext : DbContext
    {
        // inherits from base options
        public AmazonDbContext(DbContextOptions<AmazonDbContext> options) : base (options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
