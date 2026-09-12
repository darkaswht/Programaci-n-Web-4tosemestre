using ARCA_DE_NOE.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARCA_DE_NOE.Pages.Veterinarios
{
    public class IndexModel : PageModel
    {
        public List<Veterinario> Veterinarios { get; set; } = new()
        {
            new() { Id=1, Nombre="María",  Apellidos="Sánchez Ramos",  Especialidad="Cirugía",          Telefono="555-0101", Activo=true  },
            new() { Id=2, Nombre="Jorge",  Apellidos="Pérez Luna",     Especialidad="Dermatología",      Telefono="555-0202", Activo=true  },
            new() { Id=3, Nombre="Sofía",  Apellidos="Díaz Moreno",    Especialidad="Medicina General",  Telefono="555-0303", Activo=false },
        };

        public void OnGet() { }
    }
}
