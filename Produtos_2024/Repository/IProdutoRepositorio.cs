using Produtos_2024.Models;
using System.Diagnostics.Eventing.Reader;

namespace Produtos_2024.Repository
{
    public interface IProdutoRepositorio
    {
        List<ProdutoModel> BuscarTodos();
        ProdutoModel Adicionar(ProdutoModel produto);

        ProdutoModel ListarPorId(long id);

        ProdutoModel Atualizar(ProdutoModel produto);

        bool AtivarDesativar(long id);

        bool Apagar(long id);
    }
}
