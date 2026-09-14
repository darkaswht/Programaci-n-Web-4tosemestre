using ARCA_DE_NOE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARCA_DE_NOE.Pages.Citas
{
    public class EliminarModel : PageModel
    {
        public Cita Cita { get; set; } = new();

        public void OnGet(int id)
        {
            Cita = new Cita
            {
                Id = id, NombreMascota = "Rocky", NombreVeterinario = "María Sánchez",
                FechaHora = new DateTime(2026, 9, 10, 10, 30, 0)
            };
        }

        public IActionResult OnPost(int id)
        {
            return RedirectToPage("Index");
        }
    }
}
