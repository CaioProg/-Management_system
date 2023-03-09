using Microsoft.AspNetCore.Mvc;

namespace Marmoraria.Controllers
{
    public class PedidoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CadastrarPedido()
        {
            return View();
        }

        public IActionResult ExibirPedido()
        {
            return View();
        }
    }
}
