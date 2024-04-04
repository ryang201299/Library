using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Library.Models;

namespace Library.Pages {
    public class CheckedOutModel : PageModel {
        public List<Book> Books { get; set; }
        public CheckedOutModel() {
            this.Books = new List<Book> {
                new Book(1, DateTime.Now, "1984", "Some Author", "/Images/1984.jpg", true),
                new Book(2, DateTime.Now, "Catcher In The Rye", "Some other author", "/Images/CatcherInTheRye.jpg", true),
                new Book(3, DateTime.Now, "The Great Gatsby", "rando McGee", "Images/Gatsby.jpg", true),
                new Book(4, DateTime.Now, "To Kill A Mockingbird", "Someone else", "/Images/KillMockingBird.jpg", true),
                new Book(5, DateTime.Now, "Lord Of The Rings", "rando McGee", "/Images/LordOfTheRings.jpg", true),
                new Book(6, DateTime.Now, "Pride and Predjudice", "rande", "/Images/PrideAndPred.jpg", true)
            };
        }

        public void OnGet() {
        }
    }
}