using Microsoft.EntityFrameworkCore;
using ProjetoBancoMongo.Model;

namespace ProjetoBancoMongo.Dal
{
    public class CompraContext : DbContext
    {
        public CompraContext(DbContextOptions<CompraContext> options) : base(options)
        {    
        }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        
    }
}