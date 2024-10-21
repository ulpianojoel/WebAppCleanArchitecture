using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class LoginController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var model = new LoginViewModel();
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.PostAsJsonAsync("https://tusapirest.com/login", model);
            
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "PanelControl");
            }
            else
            {
                model.ErrorMessage = "Usuario o contraseña incorrectos.";
                return View("Index", model);
            }
        }
        return View("Index", model);
    }
}
