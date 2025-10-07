using Microsoft.EntityFrameworkCore;
using Microsoft.Data.Sqlite;

namespace GestaoMercado;

public class ProdutoContext: DbContext
{
    public DbSet<ProdutoDTO>  Produtos { get; set; }
    public DbSet<GestaoDTO> Gestao { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // dotnet add package Microsoft.EntityFrameworkCore.Sqlite
        optionsBuilder.UseSqlite("Data Source=D:\\\\Estudos CS Rider\\\\GestaoMercado\\\\GestaoMercado\\\\produtos.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProdutoDTO>().HasKey(x => x.Id);
        modelBuilder.Entity<GestaoDTO>().HasKey(x => x.Id);
    }
}