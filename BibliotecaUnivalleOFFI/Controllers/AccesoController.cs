using BibliotecaUnivalleOFFI.Data;
using BibliotecaUnivalleOFFI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BibliotecaUnivalleOFFI.Controllers
{
    public class AccesoController : Controller
    {
        private readonly AppDbContext _context;

        public AccesoController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string correo, string contrasena)
        {
            var usuario = _context.Usuarios
                .FirstOrDefault(u => u.Correo == correo && u.Contrasena == contrasena);

            if (usuario == null)
            {
                ViewBag.Error = "Correo o contraseña incorrectos.";
                return View();
            }

            HttpContext.Session.SetInt32("UsuarioId", usuario.Id);
            HttpContext.Session.SetString("UsuarioNombre", usuario.Nombre);
            HttpContext.Session.SetString("UsuarioRol", usuario.Rol);

            if (usuario.Rol == "Administrador")
                return RedirectToAction("Index", "Administrador");
            else if (usuario.Rol == "Bibliotecario")
                return RedirectToAction("Index", "Bibliotecario");
            else
                return RedirectToAction("Index", "UsuarioDashboard");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
