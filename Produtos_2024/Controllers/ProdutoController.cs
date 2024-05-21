using Microsoft.AspNetCore.Mvc;
using Produtos_2024.Models;
using Produtos_2024.Repository;

namespace Produtos_2024.Controllers
{
    public class ProdutoController : Controller
    {

        private readonly ProdutoRepositorio _produtoRepositorio;

        public ProdutoController(ProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

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
            _produtoRepositorio.Adicionar(produto);
            return RedirectToAction("Index");
        }
    }
}
