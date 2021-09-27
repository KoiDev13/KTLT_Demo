using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KTLT_Demo.Pages
{
    public class MH_luu_diemModel : PageModel
    {
        [BindProperty]
        public int X1 { get; set; }

        [BindProperty]
        public int Y1 { get; set; }

        public void OnGet()
        {
            X1 = 1;
            Y1 = 1;
        }
        public void OnPost()
        {
        }
    }
}
