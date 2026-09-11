using ARCA_DE_NOE.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARCA_DE_NOE.Pages.Propietarios
{
    public class IndexModel : PageModel
    {
        public List<Propietario> Propietarios { get; set; } = new()
        {
            new() { Id=1, Nombre="Ana",    Apellidos="García López",  Telefono="555-1234", Email="ana.garcia@email.com",    Activo=true  },
            new() { Id=2, Nombre="Carlos", Apellidos="Mendoza Ruiz",  Telefono="555-5678", Email="carlos.m@email.com",      Activo=true  },
            new() { Id=3, Nombre="Laura",  Apellidos="Torres Vega",   Telefono="555-9012", Email="laura.torres@email.com",  Activo=false },
        };

        public void OnGet() { }
    }
}
