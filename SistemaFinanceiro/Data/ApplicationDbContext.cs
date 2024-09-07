namespace SistemaFinanceiro.Data
{
    using Microsoft.EntityFrameworkCore;
    using Models;

    namespace SistemaFinanceiro.Data
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

            public DbSet<Pagador> Pagadores { get; set; }
            public DbSet<NotaFiscal> NotasFiscais { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                // Configurações adicionais de mapeamento se necessário
            }
        }
    }

}
