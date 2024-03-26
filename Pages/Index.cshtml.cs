using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Library.Pages {
    public class IndexModel : PageModel
    {
        public string[] Items { get; set; }
        public string[] OtherItems { get; set; }
        public string[] Friends { get; set; }

        public IndexModel()
        {
            Items = new string[] {"Apples", "Pears", "Bananas"};
            OtherItems = new string[] {"Pokemon", "Call of Duty", "BattleField"};
            Friends = new string[] {"Birdy", "Alex", "Kelly"};
        }

        public void OnGet(string name)
        {
        }
    }
}