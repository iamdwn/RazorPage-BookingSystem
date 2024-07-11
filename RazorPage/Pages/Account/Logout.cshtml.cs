using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPage.Pages.Account
{
    public class LogoutModel : PageModel
    {
        public IActionResult OnGet()
        {
            // Clear the session
            HttpContext.Session.Clear();

            // Redirect to login page or another appropriate page
            return RedirectToPage("/Index");
        }
    }
}
