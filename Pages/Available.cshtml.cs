using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Library.Models;

namespace Library.Pages {
    public class AvailableModel : PageModel {
        public List<Book> Books { get; set; }
        
        public AvailableModel() {
            this.Books = new List<Book> {
                new Book(1, DateTime.Now, "1984", "Some Author", "/Images/1984.jpg", "Fiction. Old. Classic. Loved."),
                new Book(2, DateTime.Now, "Catcher In The Rye", "Some other author", "/Images/CatcherInTheRye.jpg", "Some short description."),
                new Book(3, DateTime.Now, "The Great Gatsby", "rando McGee", "/Images/Gatsby.jpg", "Some short description."),
                new Book(4, DateTime.Now, "To Kill A Mockingbird", "Someone else", "/Images/KillMockingBird.jpg", "Some short description."),
                new Book(5, DateTime.Now, "Lord Of The Rings", "rando McGee", "/Images/LordOfTheRings.jpg", "Some short description."),
                new Book(3, DateTime.Now, "Pride and Predjudice", "rande", "/Images/PrideAndPred.jpg", "Some short description.")
            };
        }

        public void OnGet() {
        }
    }
}