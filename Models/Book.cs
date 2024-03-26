using System;

namespace Library.Models {
    public class Book {
        public int Id { get; set; }
        public DateTime Year { get; set; }
        public string Name { get; set; }
        public byte[]? Image { get; set; }
        public string Author { get; set; }
        public bool CheckedOut { get; set; }
        public int? CheckedOutBy { get; set; }

        public Book(int id, DateTime year, string name, string author, bool checkedOut = false) {
            this.Id = id;
            this.Year = year;
            this.Name = name;
            this.Author = author;
            this.CheckedOut = checkedOut;
        }

        public Book(int id, DateTime year, string name, byte[] image, string author, bool checkedOut = false) {
            this.Id = id;
            this.Year = year;
            this.Name = name;
            this.Image = image;
            this.Author = author;
            this.CheckedOut = checkedOut;
        }
    }
}