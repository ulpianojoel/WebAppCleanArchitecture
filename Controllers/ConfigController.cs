using Microsoft.AspNetCore.Mvc;

namespace WebAppCleanArchitecture.Controllers
{
    public class ConfigController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new ConfigViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult GuardarConfig(ConfigViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Lógica para guardar la configuración
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}