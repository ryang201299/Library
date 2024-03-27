using System;

namespace Library.Models {
    public class Book {
        public int Id { get; set; }
        public DateTime Year { get; set; }
        public string Name { get; set; }
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public byte[]? Image { get; set; }
        public string ImageLocation { get; set; } // temporary for testing images.
        public string Author { get; set; }
        public bool CheckedOut { get; set; }
        public int? CheckedOutBy { get; set; }

        public Book(int id, DateTime year, string name, string author, string imgLoc, bool checkedOut = false) {
            this.Id = id;
            this.Year = year;
            this.Name = name;
            this.Author = author;
            this.CheckedOut = checkedOut;
            this.ImageLocation = imgLoc;
        }

        public Book(int id, DateTime year, string name, byte[] image, string author, string imgLoc, bool checkedOut = false) {
            this.Id = id;
            this.Year = year;
            this.Name = name;
            this.Image = image;
            this.Author = author;
            this.CheckedOut = checkedOut;
            this.ImageLocation = imgLoc;
        }

        public Book(int id, DateTime year, string name, string author, string imgLoc, string shortDesc, bool checkedOut = false) {
            this.Id = id;
            this.Year = year;
            this.Name = name;
            this.Author = author;
            this.CheckedOut = checkedOut;
            this.ImageLocation = imgLoc;
            this.ShortDescription = shortDesc;
        }
    }
}