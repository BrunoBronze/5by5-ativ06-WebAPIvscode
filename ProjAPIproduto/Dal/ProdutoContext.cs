using Microsoft.EntityFrameworkCore;
using ProjAPIproduto.Models;

namespace ProjAPIproduto.Dal
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
    }
}