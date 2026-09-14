using ARCA_DE_NOE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ARCA_DE_NOE.Pages.Mascotas
{
    public class EditarModel : PageModel
    {
        [BindProperty]
        public Mascota Mascota { get; set; } = new();

        public void OnGet(int id)
        {
            Mascota = new Mascota
            {
                Id = id, Nombre = "Rocky", NombrePropietario = "Ana García",
                Especie = "Perro", Raza = "Labrador", Color = "Amarillo",
                FechaNacimiento = new DateOnly(2020, 3, 15), Activo = true
            };
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid) return Page();
            return RedirectToPage("Index");
        }
    }
}
