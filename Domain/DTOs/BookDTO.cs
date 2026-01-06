using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_WinForms.Domain.DTOs
{
    public class BookDTO
    {
        public int Code { get; set; }
        public string Isbn { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;
        public DateTime RealeseDate { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Author { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;

        public BookDTO() { }
        public BookDTO(int code,string isnb ,string title, DateTime realeseDate, double price, int stock, string author, string genre)
        {
            Code = code;
            Title = title;
            Isbn = Isbn;
            RealeseDate = realeseDate;
            Price = price;
            Stock = stock;
            Author = author;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"{Code} - {Title} - {Author} - {Genre}";
        }
    }
}
