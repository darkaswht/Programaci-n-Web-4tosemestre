using ARCA_DE_NOE.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARCA_DE_NOE.Pages.Mascotas
{
    public class IndexModel : PageModel
    {
        public List<Mascota> Mascotas { get; set; } = new()
        {
            new() { Id=1, Nombre="Rocky", NombrePropietario="Ana García",     Especie="Perro", Raza="Labrador",         Color="Amarillo",      FechaNacimiento=new DateOnly(2020,3,15),  Activo=true  },
            new() { Id=2, Nombre="Mia",   NombrePropietario="Carlos Mendoza", Especie="Gato",  Raza="Siamés",           Color="Blanco y café", FechaNacimiento=new DateOnly(2019,7,22),  Activo=true  },
            new() { Id=3, Nombre="Toby",  NombrePropietario="Ana García",     Especie="Perro", Raza="Golden Retriever", Color="Dorado",        FechaNacimiento=new DateOnly(2021,11,5),  Activo=false },
        };

        public void OnGet() { }
    }
}
