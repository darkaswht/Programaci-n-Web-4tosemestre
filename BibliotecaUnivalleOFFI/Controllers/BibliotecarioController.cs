using BibliotecaUnivalleOFFI.Data;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaUnivalleOFFI.Controllers
{
    public class BibliotecarioController : Controller
    {
        private readonly AppDbContext _context;

        public BibliotecarioController(AppDbContext context)
        {
            _context = context;
        }

        private bool EsBibliotecario()
        {
            var rol = HttpContext.Session.GetString("UsuarioRol");
            return rol == "Bibliotecario" || rol == "Administrador";
        }

        public IActionResult Index()
        {
            if (!EsBibliotecario()) return RedirectToAction("Login", "Acceso");
            ViewBag.TotalLibros = _context.Libros.Count();
            ViewBag.TotalPrestamos = _context.Prestamos.Count();
            return View();
        }

        public IActionResult Libros()
        {
            if (!EsBibliotecario()) return RedirectToAction("Login", "Acceso");
            var libros = _context.Libros.ToList();
            return View(libros);
        }

        public IActionResult Prestamos()
        {
            if (!EsBibliotecario()) return RedirectToAction("Login", "Acceso");
            var prestamos = _context.Prestamos
                .Select(p => new
                {
                    p.Id,
                    p.FechaPrestamo,
                    p.FechaDevolucion,
                    p.Estado,
                    LibroTitulo = p.Libro != null ? p.Libro.Titulo : "",
                    UsuarioNombre = p.Usuario != null ? p.Usuario.Nombre : ""
                }).ToList();
            ViewBag.Prestamos = prestamos;
            return View();
        }
    }
}
