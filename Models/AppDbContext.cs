using Microsoft.EntityFrameworkCore;
namespace MinhaApi.Models
{
 public class AppDbContext : DbContext
 {
 public AppDbContext(DbContextOptions<AppDbContext> options)
 : base(options)
 {
 }
 public DbSet<Produto> Produtos { get; set; }

protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Esta linha força o mapeamento do modelo para o nome da tabela em minúsculas
            modelBuilder.Entity<Produto>().ToTable("produtos");
	    modelBuilder.Entity<Produto>().Property(p => p.Id).HasColumnName("id");
            modelBuilder.Entity<Produto>().Property(p => p.Nome).HasColumnName("nome");
            modelBuilder.Entity<Produto>().Property(p => p.Preco).HasColumnName("preco");
            modelBuilder.Entity<Produto>().Property(p => p.Quantidade).HasColumnName("quantidade");
        }
 }
}
