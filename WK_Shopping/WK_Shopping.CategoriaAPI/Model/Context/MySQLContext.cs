using Microsoft.EntityFrameworkCore;

namespace WK_Shopping.CategoriaAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(new Categoria 
            { 
                Id = 1,
                Nome = "T-shirt"
            });
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 2,
                Nome = "Action Figure"
            });
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 3,
                Nome = "Sweatshirt"
            });
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 4,
                Nome = "Book"
            });
        }
    }
}
