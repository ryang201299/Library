using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Library.Models;
using Library.Data;
using Microsoft.EntityFrameworkCore;

namespace Library.Pages {
    public class CheckedOutModel : PageModel {
        public List<Book> Books { get; set; }
        public LibraryContext Context { get; set; }
        public CheckedOutModel(LibraryContext context) {
            this.Context = context;
        }

        public async Task OnGetAsync() {
            this.Books = await Context.Books.ToListAsync();
        }
    }
}