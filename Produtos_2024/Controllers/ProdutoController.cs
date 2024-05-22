using Microsoft.AspNetCore.Mvc;
using Produtos_2024.Models;
using Produtos_2024.Repository;

namespace Produtos_2024.Controllers
{
    public class ProdutoController : Controller
    {

        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public IActionResult Index()
        {

            //buscar produtos no banco de dados
            List<ProdutoModel> listagem = _produtoRepositorio.BuscarTodos();
            return View(listagem);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ProdutoModel produto)
        {

            produto.DataDeRegistro = DateTime.Now;
            // solicita cadastro do produto
            _produtoRepositorio.Adicionar(produto);

            return RedirectToAction("Index");
        }
    }
}
