using APICatalogo.Models;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Context
{
    public class AppDBcontext : DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> options) : base(options) 
        { }

        public DbSet<Categoria>? Categorias { get; set; }

        public DbSet<Produto>? Produtos { get; set; }
    }
}
