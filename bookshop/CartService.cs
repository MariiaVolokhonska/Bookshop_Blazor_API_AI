﻿using System.Collections.Generic;
using bookshop.Models;
namespace bookshop
{
    public class CartService
    {
        public List<Book> BooksInCart { get; set; } = new List<Book>();

        public void AddToCart(Book book)
        {
            if (book != null && !BooksInCart.Any(b => b.Title == book.Title))
            {
                BooksInCart.Add(book);
            }
        }

        public void DeleteFromCart(Book book)
        {
            BooksInCart.Remove(book);
        }

        public double GetTotalPrice()
        {
            return BooksInCart.Sum(b => b.Price ?? 0);
        }
        
    }
}
