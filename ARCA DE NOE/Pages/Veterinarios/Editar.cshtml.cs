using ARCA_DE_NOE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARCA_DE_NOE.Pages.Veterinarios
{
    public class EditarModel : PageModel
    {
        [BindProperty]
        public Veterinario Veterinario { get; set; } = new();

        public void OnGet(int id)
        {
            Veterinario = new Veterinario
            {
                Id = id, Nombre = "María", Apellidos = "Sánchez Ramos",
                Especialidad = "Cirugía", Telefono = "555-0101", Activo = true
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            return RedirectToPage("Index");
        }
    }
}
