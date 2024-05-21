using Microsoft.EntityFrameworkCore;
using Produtos_2024.Models;

namespace Produtos_2024.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options) {}

        public DbSet<ProdutoModel> Produto { get; set; }
    }
}
