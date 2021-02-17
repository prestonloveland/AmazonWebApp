/*
 * Preston Loveland
 * Assignment 5
 * Section 1 Group 11
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonWebApp.Models
{
    //class containing all the information needed about each book instance
    public class Book
    {
        [Key, Required]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Publisher { get; set; }
        //regex for ISBN number
        [Required, RegularExpression(@"^(?= (?:\D *\d){10}(?:(?:\D*\d){3})?$)[\d-]+$")]
        public string ISBN { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public double Price { get; set; }

    }
}
