using System.ComponentModel.DataAnnotations;

namespace BibliotecaUnivalleOFFI.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Título")]
        public string Titulo { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Autor")]
        public string Autor { get; set; } = string.Empty;

        [Required]
        [Display(Name = "ISBN")]
        public string ISBN { get; set; } = string.Empty;

        [Display(Name = "Disponible")]
        public bool Disponible { get; set; } = true;

        public ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
    }
}
