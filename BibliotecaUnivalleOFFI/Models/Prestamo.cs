using System.ComponentModel.DataAnnotations;

namespace BibliotecaUnivalleOFFI.Models
{
    public class Prestamo
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Fecha de Préstamo")]
        public DateTime FechaPrestamo { get; set; } = DateTime.Now;

        [Display(Name = "Fecha de Devolución")]
        public DateTime? FechaDevolucion { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; } = "Activo";

        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        public int LibroId { get; set; }
        public Libro? Libro { get; set; }
    }
}
