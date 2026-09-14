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
            Mascota = new Mascota { Id = id, Nombre = "Rocky" };
        }

        public IActionResult OnPost(int id)
        {
            return RedirectToPage("Index");
        }
    }
}
