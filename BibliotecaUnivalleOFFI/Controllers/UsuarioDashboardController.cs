using BibliotecaUnivalleOFFI.Data;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaUnivalleOFFI.Controllers
{
    public class UsuarioDashboardController : Controller
    {
        private readonly AppDbContext _context;

        public UsuarioDashboardController(AppDbContext context)
        {
            _context = context;
        }

        private bool EstaLogueado()
        {
            return HttpContext.Session.GetInt32("UsuarioId") != null;
        }

        public IActionResult Index()
        {
            if (!EstaLogueado()) return RedirectToAction("Login", "Acceso");
            return View();
        }

        public IActionResult Catalogo()
        {
            if (!EstaLogueado()) return RedirectToAction("Login", "Acceso");
            var libros = _context.Libros.ToList();
            return View(libros);
        }

        public IActionResult MisPrestamos()
        {
            if (!EstaLogueado()) return RedirectToAction("Login", "Acceso");
            var usuarioId = HttpContext.Session.GetInt32("UsuarioId");
            var prestamos = _context.Prestamos
                .Where(p => p.UsuarioId == usuarioId)
                .Select(p => new
                {
                    p.Id,
                    p.FechaPrestamo,
                    p.FechaDevolucion,
                    p.Estado,
                    LibroTitulo = p.Libro != null ? p.Libro.Titulo : ""
                }).ToList();
            ViewBag.Prestamos = prestamos;
            return View();
        }
    }
}
