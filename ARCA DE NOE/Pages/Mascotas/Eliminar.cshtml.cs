using ARCA_DE_NOE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARCA_DE_NOE.Pages.Mascotas
{
    public class EliminarModel : PageModel
    {
        public Mascota Mascota { get; set; } = new();

        public void OnGet(int id)
        {
            // TODO: cargar desde base de datos
            Mascota = new Mascota { Id = id, Nombre = "Rocky" };
        }

        public IActionResult OnPost(int id)
        {
            // TODO: eliminar de base de datos
            return RedirectToPage("Index");
        }
    }
}
