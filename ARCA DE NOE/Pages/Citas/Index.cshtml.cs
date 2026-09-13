using ARCA_DE_NOE.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARCA_DE_NOE.Pages.Citas
{
    public class IndexModel : PageModel
    {
        public List<Cita> Citas { get; set; } = new()
        {
            new() { Id=1, NombreMascota="Rocky", NombreVeterinario="María Sánchez", FechaHora=new DateTime(2026,9,10,10,30,0), Motivo="Revisión general",  Estado=EstadoCita.Pendiente,   Diagnostico="" },
            new() { Id=2, NombreMascota="Mia",   NombreVeterinario="Jorge Pérez",   FechaHora=new DateTime(2026,9,8, 14,0, 0), Motivo="Problema de piel",  Estado=EstadoCita.Completada, Diagnostico="Dermatitis leve. Tratamiento tópico." },
            new() { Id=3, NombreMascota="Toby",  NombreVeterinario="Sofía Díaz",    FechaHora=new DateTime(2026,9,5, 9, 0, 0), Motivo="Vacunación anual",  Estado=EstadoCita.Cancelada,  Diagnostico="" },
        };

        public void OnGet() { }
    }
}
