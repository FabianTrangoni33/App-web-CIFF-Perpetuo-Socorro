using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CiffPerpetuoSocorroWeb.Data;

namespace CiffPerpetuoSocorroWeb.Controllers
{
    public class ActividadesController : Controller
    {
        private readonly CiffContext _context;

        // Le pasamos nuestra base de datos al controlador al arrancar
        public ActividadesController(CiffContext context)
        {
            _context = context;
        }

        // 1. PANTALLA PRINCIPAL: Listado de Actividades con su Educador
        public async Task<IActionResult> Index()
        {
            // El .Include(a => a.Educador) es un "JOIN" automático. 
            // Trae la actividad y también los datos del profesor asignado.
            var actividades = await _context.Actividades.Include(a => a.Educador).ToListAsync();
            return View(actividades);
        }

        // 2. PANTALLA DE DETALLE: Ver una actividad y sus beneficiarios anotados
        public async Task<IActionResult> Details(int id)
        {
            // Buscamos la actividad por su ID, incluyendo al Educador y la lista de niños
            var actividad = await _context.Actividades
                .Include(a => a.Educador)
                .Include(a => a.Beneficiarios)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (actividad == null)
            {
                return NotFound(); // Error 404 si no existe
            }

            return View(actividad);
        }
    }
}