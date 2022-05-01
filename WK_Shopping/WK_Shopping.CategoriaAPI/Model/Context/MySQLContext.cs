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
                Nome = "Action Figure"
            });
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 4,
                Nome = "T-shirt"
            });
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 5,
                Nome = "T-shirt"
            });
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 6,
                Nome = "T-shirt"
            });
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 7,
                Nome = "Sweatshirt"
            });
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 8,
                Nome = "Book"
            });
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 9,
                Nome = "Action Figure"
            });
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 10,
                Nome = "T-shirt"
            });
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 11,
                Nome = "T-shirt"
            });
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id = 12,
                Nome = "T-shirt"
            });
        }
    }
}
