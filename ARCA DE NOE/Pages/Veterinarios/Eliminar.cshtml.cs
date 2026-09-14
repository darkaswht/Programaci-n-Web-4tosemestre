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
            Veterinario = new Veterinario { Id = id, Nombre = "María", Apellidos = "Sánchez Ramos" };
        }

        public IActionResult OnPost(int id)
        {
            return RedirectToPage("Index");
        }
    }
}
