using ARCA_DE_NOE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARCA_DE_NOE.Pages.Citas
{
    public class EditarModel : PageModel
    {
        [BindProperty]
        public Cita Cita { get; set; } = new();

        public void OnGet(int id)
        {
            // TODO: cargar desde base de datos
            Cita = new Cita
            {
                Id = id, NombreMascota = "Rocky", NombreVeterinario = "María Sánchez",
                FechaHora = new DateTime(2026, 9, 10, 10, 30, 0),
                Motivo = "Revisión general", Estado = EstadoCita.Pendiente, Diagnostico = ""
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
