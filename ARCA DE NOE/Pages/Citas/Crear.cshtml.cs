using ARCA_DE_NOE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARCA_DE_NOE.Pages.Citas
{
    public class CrearModel : PageModel
    {
        [BindProperty]
        public Cita Cita { get; set; } = new();

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            // TODO: persistir en base de datos
            return RedirectToPage("Index");
        }
    }
}
