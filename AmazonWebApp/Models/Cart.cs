using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonWebApp.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();

        //method to add item to a users cart based on Book Id
        public virtual void AddItem(Book book, int qty)
        {
            CartLine line = Lines
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();

            //sees if Book is already in cart, if not add, if so add 1
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        //method to remove a line from the cart
        public virtual void RemoveLine(Book book) =>
            Lines.RemoveAll(x => x.Book.BookId == book.BookId);

        //method to clear the cart
        public virtual void Clear() => Lines.Clear();

        //method to list the total price of Books
        public decimal ComputeTotalSum() =>
            (decimal)Lines.Sum(e => e.Book.Price * e.Quantity);


        //class to create a Cart object to simplify data storage
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }

    }
}
