using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Library.Models;

namespace Library.Pages {
    public class CheckedOutModel : PageModel {
        public List<Book> CheckedOutBooks { get; set; }
        public CheckedOutModel() {
            this.CheckedOutBooks = new List<Book> {
                new Book(1, DateTime.Now, "Harry Potter", "Some Author", true),
                new Book(2, DateTime.Now, "Starwars", "Some other author", true),
                new Book(3, DateTime.Now, "Winnie the pooh", "rando McGee", true)
            };
        }

        public void OnGet() {
            
        }
    }
}