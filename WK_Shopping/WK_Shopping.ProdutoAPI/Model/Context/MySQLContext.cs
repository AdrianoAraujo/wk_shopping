using Microsoft.EntityFrameworkCore;

namespace WK_Shopping.ProdutoAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
    }
}
