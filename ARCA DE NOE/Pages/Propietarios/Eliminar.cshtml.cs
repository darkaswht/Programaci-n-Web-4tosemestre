using ARCA_DE_NOE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARCA_DE_NOE.Pages.Propietarios
{
    public class EliminarModel : PageModel
    {
        public Propietario Propietario { get; set; } = new();

        public void OnGet(int id)
        {
            Propietario = new Propietario { Id = id, Nombre = "Ana", Apellidos = "García López" };
        }

        public IActionResult OnPost(int id)
        {
            return RedirectToPage("Index");
        }
    }
}
