/*
 * Preston Loveland
 * Assignment 5
 * Section 1 Group 11
 * */
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonWebApp.Models
{
    public class SeedData
        //class to enter in data into database
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            AmazonDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<AmazonDbContext>();
            //makes sure there is no data present first
            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            //adds data if none is present
            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirstName = "Victor",
                        AuthorLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95,
                        PageNumber = 1488
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirstName = "Doris Kearns",
                        AuthorLastName = "Goodwin",
                        Publisher = "Simon and Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58,
                        PageNumber = 944

                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirstName = "Alice",
                        AuthorLastName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54,
                        PageNumber = 832

                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirstName = "Ronald C",
                        AuthorLastName = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61,
                        PageNumber = 864

                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirstName = "Laura",
                        AuthorLastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33,
                        PageNumber = 528

                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Crichton",
                        Publisher = "Vintage ",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95,
                        PageNumber = 288

                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirstName = "Cal",
                        AuthorLastName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99,
                        PageNumber = 304

                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66,
                        PageNumber = 240

                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirstName = "Richard",
                        AuthorLastName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16,
                        PageNumber = 400

                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirstName = "John",
                        AuthorLastName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03,
                        PageNumber = 642

                    },
                    new Book
                    {
                        Title = "A Tale of Two Cities",
                        AuthorFirstName = "Charles",
                        AuthorLastName = "Dickens",
                        Publisher = "Chapman and Hall",
                        ISBN = "978-0582030473",
                        Classification = "Fiction",
                        Category = "Historical",
                        Price = 3.99,
                        PageNumber = 448

                    },
                    new Book
                    {
                        Title = "Eragon",
                        AuthorFirstName = "Christpoher",
                        AuthorLastName = "Paolini",
                        Publisher = "Paolini LLC",
                        ISBN = "978-0375826689",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        Price = 15.61,
                        PageNumber = 544

                    },
                    new Book
                    {
                        Title = "Eldest",
                        AuthorFirstName = "Christpoher",
                        AuthorLastName = "Paolini",
                        Publisher = "Paolini LLC",
                        ISBN = "978-0375826702",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        Price = 15.21,
                        PageNumber = 694

                    });

                context.SaveChanges();
            }
        }
    }
}
