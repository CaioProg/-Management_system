using Microsoft.AspNetCore.Mvc;

namespace Marmoraria.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarCliente()
        {
            return View();
        }

        public IActionResult ExibirCliente()
        {
            return View();
        }
    }
}
