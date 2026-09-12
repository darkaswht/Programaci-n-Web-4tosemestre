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
            // TODO: cargar desde base de datos
            Veterinario = new Veterinario
            {
                Id = id, Nombre = "María", Apellidos = "Sánchez Ramos",
                Especialidad = "Cirugía", Telefono = "555-0101", Activo = true
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            // TODO: actualizar en base de datos
            return RedirectToPage("Index");
        }
    }
}
