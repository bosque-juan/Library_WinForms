using Library_WinForms.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WinForms.Domain.Entities
{
    public class Book
    {
        private int code;
        private string isbn;
        private string title;
        private double price;
        private string description;
        private int stock;
        private Genre genre;
        private Publisher publisher;
        private DateTime releaseDate;
        private Book_Language languaje;
        private Author author;


        public int Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public Genre Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public Publisher _Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
        public Book_Language Languaje
        {
            get { return languaje; }
            set { languaje = value; }
        }
        public Author Author
        {
            get { return author; }
            set { author = value; }
        }


        override public string ToString()
        {
            return code + " - " + title;
        }

    }
}
