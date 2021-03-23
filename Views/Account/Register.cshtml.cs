
using System.Threading.Tasks;
using Bookallocationsystem.Models.AppUsers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookallocationsystem.Views.Account
{
    public class RegisterModel : PageModel
    {
        public string Name { get; set; }
        [BindProperty]
        public  Register Register { get; set; }
        public IActionResult  OnGet()
        {
             return Page();
        }
      public async Task<IActionResult> OnPostAsync()
        {
           if (!ModelState.IsValid)
            {
                return Page();
            }

          
            return RedirectToPage("./2");
        }
    }
}
