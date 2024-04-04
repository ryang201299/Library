using System;

namespace Library.Models {
    public class Book {
        public int Id { get; set; }
        public DateTime Year { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public string ImageLocation { get; set; }
        public string Author { get; set; }
        public bool CheckedOut { get; set; }
        public int? CheckedOutById { get; set; }


        public Book(int id, DateTime year, string name, string author, string imageLocation, string shortDescription, bool checkedOut = false) {
            this.Id = id;
            this.Year = year;
            this.Name = name;
            this.Author = author;
            this.ImageLocation = imageLocation;
            this.ShortDescription = shortDescription;
            this.CheckedOut = checkedOut;
        }
    }
}