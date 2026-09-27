using BibliotecaUnivalleOFFI.Data;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaUnivalleOFFI.Controllers
{
    public class AdministradorController : Controller
    {
        private readonly AppDbContext _context;

        public AdministradorController(AppDbContext context)
        {
            _context = context;
        }

        private bool EsAdministrador()
        {
            return HttpContext.Session.GetString("UsuarioRol") == "Administrador";
        }

        public IActionResult Index()
        {
            if (!EsAdministrador()) return RedirectToAction("Login", "Acceso");
            ViewBag.TotalLibros = _context.Libros.Count();
            ViewBag.TotalUsuarios = _context.Usuarios.Count();
            ViewBag.TotalPrestamos = _context.Prestamos.Count();
            return View();
        }

        public IActionResult Libros()
        {
            if (!EsAdministrador()) return RedirectToAction("Login", "Acceso");
            var libros = _context.Libros.ToList();
            return View(libros);
        }

        public IActionResult Usuarios()
        {
            if (!EsAdministrador()) return RedirectToAction("Login", "Acceso");
            var usuarios = _context.Usuarios.ToList();
            return View(usuarios);
        }

        public IActionResult Prestamos()
        {
            if (!EsAdministrador()) return RedirectToAction("Login", "Acceso");
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
