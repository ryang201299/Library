using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Library.Pages {
    public class IndexModel : PageModel
    {

        public IndexModel()
        {
            // Will present a login screen to the user to authenticate against the database before presenting the home page.
        }

        public void OnGet(string name)
        {
        }
    }
}