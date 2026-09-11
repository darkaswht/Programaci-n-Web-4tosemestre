using ARCA_DE_NOE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARCA_DE_NOE.Pages.Propietarios
{
    public class EditarModel : PageModel
    {
        [BindProperty]
        public Propietario Propietario { get; set; } = new();

        public void OnGet(int id)
        {
            // TODO: cargar desde base de datos por id
            Propietario = new Propietario
            {
                Id = id, Nombre = "Ana", Apellidos = "García López",
                Telefono = "555-1234", Email = "ana.garcia@email.com", Activo = true
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
