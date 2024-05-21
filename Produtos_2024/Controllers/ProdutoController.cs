using Microsoft.AspNetCore.Mvc;

namespace Produtos_2024.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }
    }
}
