using ARCA_DE_NOE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARCA_DE_NOE.Pages.Propietarios
{
    public class CrearModel : PageModel
    {
        [BindProperty]
        public Propietario Propietario { get; set; } = new();

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            return RedirectToPage("Index");
        }
    }
}
