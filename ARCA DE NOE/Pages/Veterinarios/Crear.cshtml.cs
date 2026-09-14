using ARCA_DE_NOE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARCA_DE_NOE.Pages.Veterinarios
{
    public class CrearModel : PageModel
    {
        [BindProperty]
        public Veterinario Veterinario { get; set; } = new();

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            return RedirectToPage("Index");
        }
    }
}
