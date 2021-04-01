using Microsoft.EntityFrameworkCore;
using ProjAPIcliente.Models;

namespace ProjAPIcliente.Dal
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
    }
}