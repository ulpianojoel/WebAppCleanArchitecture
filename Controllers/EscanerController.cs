using Microsoft.AspNetCore.Mvc;

namespace WebAppCleanArchitecture.Controllers
{
    public class EscanerController : Controller
    {
        [HttpGet]
        public IActionResult Autorizacion()
        {
            // Simula la llamada al API que devuelve la lista de escáneres
            var model = new EscanerViewModel
            {
                Escaneres = ObtenerEscaneresSimulados
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult CambiarEstadoEscaner(int id)
        {
            var escaneres = ObtenerEscaneresSimulados;
            var escaner = escaneres.Find(e => e.Id == id);

            if (escaner != null)
            {
                escaner.Activo = !escaner.Activo; // Cambia el estado
            }

            var model = new EscanerViewModel { Escaneres = escaneres };
            return View("Autorizacion", model);
        }

        private static List<Escaner> ObtenerEscaneresSimulados
        {
            get
            {
                return new()
        {
            new() { Id = 1, Nombre = "Escáner 1", Activo = true },
            new() { Id = 2, Nombre = "Escáner 2", Activo = false },
            new() { Id = 3, Nombre = "Escáner 3", Activo = true }
        };
            }
        }
    }
}