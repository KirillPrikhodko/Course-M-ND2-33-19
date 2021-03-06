﻿using System;
using System.Collections.Generic;

namespace BookCatalogue
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime DateOfissue { get; set; }
        public Genre Genre { get; set; }
        public bool IsPaper { get; set; }
        public DeliveryOptions deliveryOption { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}; Name: \"{Title}\"; by {Author} ({DateOfissue})";
        }
    }
}
