using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Staffed.Pages
{
    public class HomeModel : PageModel
    {
        public List<LazySodData> Items { get; set; }

        public HomeModel()
        {
            Items = new List<LazySodData>
            {
                new LazySodData { Name = "Item 1", Value = "" },
                new LazySodData { Name = "Item 2", Value = "" },
                new LazySodData { Name = "Item 3", Value = "" },
                new LazySodData { Name = "Item 4", Value = "" },
                new LazySodData { Name = "Item 5", Value = "" },
            };
        }

        public void OnGet()
        {
        }
    }

    public class LazySodData
    {
        public string Name { get; set; }

        public string Value { get; set; }
    }
}