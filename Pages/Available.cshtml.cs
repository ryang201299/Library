using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Library.Models;

namespace Library.Pages {
    public class AvailableModel : PageModel {
        public List<Book> AvailableBooks { get; set; }
        
        public AvailableModel() {
            this.AvailableBooks = new List<Book> {
                new Book(1, DateTime.Now, "Harry Potter", "Some Author"),
                new Book(2, DateTime.Now, "Starwars", "Some other author"),
                new Book(3, DateTime.Now, "Winnie the pooh", "rando McGee")
            };
        }

        public void OnGet() {
            
        }
    }
}