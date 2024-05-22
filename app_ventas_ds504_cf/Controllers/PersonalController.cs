using Microsoft.AspNetCore.Mvc;
using ProyectoDS504_cf.Models;
using web_ventas_ds504_cf.Data;

namespace web_ventas_ds504_cf.Controllers
{
    public class PersonalController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonalController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Personal> listarPersonal = _context.Personal;
            return View(listarPersonal);
        }
    }
}

