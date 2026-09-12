using ARCA_DE_NOE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARCA_DE_NOE.Pages.Veterinarios
{
    public class EliminarModel : PageModel
    {
        public Veterinario Veterinario { get; set; } = new();

        public void OnGet(int id)
        {
            // TODO: cargar desde base de datos
            Veterinario = new Veterinario { Id = id, Nombre = "María", Apellidos = "Sánchez Ramos" };
        }

        public IActionResult OnPost(int id)
        {
            // TODO: eliminar de base de datos
            return RedirectToPage("Index");
        }
    }
}
