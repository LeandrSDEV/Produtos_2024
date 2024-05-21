using Microsoft.AspNetCore.Mvc;
using Produtos_2024.Models;

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

        [HttpPost]
        public IActionResult Criar(ProdutoModel produto)
        {
            // solicitar cadasto do produto
            return RedirectToAction("Index");
        }
    }
}
