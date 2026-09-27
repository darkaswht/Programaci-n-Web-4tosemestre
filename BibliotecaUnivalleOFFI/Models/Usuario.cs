using System.ComponentModel.DataAnnotations;

namespace BibliotecaUnivalleOFFI.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Correo")]
        public string Correo { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Contraseña")]
        public string Contrasena { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Rol")]
        public string Rol { get; set; } = string.Empty;

        public ICollection<Prestamo> Prestamos { get; set; } = new List<Prestamo>();
    }
}
